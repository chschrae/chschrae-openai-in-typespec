﻿using OpenAI.Models;
using System.Diagnostics;
using System.Text.Json;

namespace AzureOpenAI.Models;

public static class AzureModelExtensions
{
    // Input model property
    // Note: on the input-side, we are unable to type-check that we're using an Azure
    // model, because the end-user created an instance of an unbranded model.  We'll
    // later convert this to an Azure model that can serialize to the Azure format,
    // but for now, we need to stash the values in a collection of objects that we'll
    // use to populate the Azure model properties later.
    public static IList<AzureChatExtensionConfiguration> GetDataSources(this CreateChatCompletionRequest request)
    {
        // TODO: How can we validate that this is being called in the right context,
        // e.g. user is using an Azure client instance and not an unbranded one?

        // Note:
        //   1. The patterns here are different for input and output
        //   2. The extension properties are actually quite simple -- they just get
        //      or set stuff in either the input or output properties dictionaries.
        //
        // TODO: What is the interplay of SerializedAdditionalRawData and 
        // AdditionalTypedProperties?  i.e. in a round-trip scenario, if we
        // wanted to mutate a SeriazliedAdditionalRawData, do we deserialize it
        // and stick it in AdditionalTypedProperties (are these "deserialized
        // additional properties, e.g.?).

        // TODO: what is our concurrency story for models in unbranded clients?
        // Are we happy with taking the Azure client stance of "models don't need
        // to be thread-safe because they are rarely shared between threads"? 
        JsonModelList<AzureChatExtensionConfiguration> dataSources;

        if (request.SerializedAdditionalRawData.TryGetValue("data_sources", out object? value))
        {
            Debug.Assert(value is JsonModelList<AzureChatExtensionConfiguration>);

            dataSources = (value as JsonModelList<AzureChatExtensionConfiguration>)!;
        }
        else
        {
            dataSources = [];
            request.SerializedAdditionalRawData.Add("data_sources", dataSources);
        }

        return dataSources;
    }

    // Output property
    // Note: we can just create an internal subtype, and we're done
    // TODO: get the value from the Azure model property.
    public static AzureChatExtensionsMessageContext? GetAzureExtensionsContext(this ChatCompletionResponseMessage message)
    {
        // TODO: How can we validate that this is being called in the right context,
        // e.g. user is using an Azure client instance and not an unbranded one?
        // Answer: when request is composed in convenience method, we validate the format
        // against whether these extension methods have been called.
        // Observation -- this works for inputs, but is there a way for it to work 
        // for outputs?  When we create the response model, we know which client we're in,
        // so we can use that.  The alternative is to fail silently because the properties
        // just aren't present.

        if (message.SerializedAdditionalRawData.TryGetValue("context", out BinaryData? context))
        {
            using JsonDocument doc = JsonDocument.Parse(context);
            return AzureChatExtensionsMessageContext.DeserializeAzureChatExtensionsMessageContext(doc.RootElement);

            // TODO: once retrieved, should this be stored in AdditionalTypedProperties, e.g.
            // in case the end-user mutates it in a round-trip scenario?  If so, should it be
            // removed from SerializedAdditionalRawData so it's only in one place?
        }

        return null;
    }

    //public static void SetDataSource(this CreateChatCompletionRequest request, AzureChatExtensionConfiguration dataSource)
    //{
    //    Argument.AssertNotNull(dataSource, nameof(dataSource));

    //    // TODO: we can do it slow via MRW.Write to BinaryData;
    //    // can we do it fast via MRW.Write to Utf8JsonWriter?

    //    // TODO: Does it matter to pass MRW Options here?
    //    //BinaryData serializedValue = ModelReaderWriter.Write(dataSource);

    //    // Note: One observation here is - working in the "BinaryData space" is 
    //    // different depending on input/output models.  We could make it all 
    //    // strongly-typed for input, but we'd have a lot of properties to [EBN].

    //    // If the BinaryData represents JSON, then we need to mutate the JSON
    //    // to add a collection, and this is expensive.

    //    // We could use MutableJsonDocument 😮, JsonNode, etc.
    //    // We could keep separate property bags for input and output types, i.e.
    //    // for different scenarios.
    //    // We could do something like PipelineMessage and hold an ArrayBackedPropertyBag

    //    // For now: Let's have serialized raw data and strongly-typed additional properties.
    //    // This lets us wait to serialize them until we can do it in an optimal fashion.

    //    // Add the list if it doesn't already exist
    //    JsonModelList<AzureChatExtensionConfiguration> dataSources;

    //    if (request.AdditionalTypedProperties.TryGetValue("data_sources", out object? value))
    //    {
    //        Debug.Assert(value is JsonModelList<AzureChatExtensionConfiguration>);

    //        dataSources = (value as JsonModelList<AzureChatExtensionConfiguration>)!;
    //    }
    //    else
    //    {
    //        dataSources = [];
    //        request.AdditionalTypedProperties.Add("data_sources", dataSources);
    //    }

    //    dataSources.Add(dataSource);
    //}

    //// TODO: return type for collection?
    //public static IList<AzureChatExtensionConfiguration>? GetDataSources(this CreateChatCompletionRequest request)
    //{
    //    if (!request.AzureProperties.TryGetValue("data_sources", out BinaryData? value))
    //    {
    //        return null;
    //    }

    //    // TODO: Notice that the generator would create this using
    //    // the same serialization/deserialization code they would typically
    //    // put into a model.

    //    if (property.NameEquals("data_sources"u8))
    //    {
    //        if (property.Value.ValueKind == JsonValueKind.Null)
    //        {
    //            continue;
    //        }
    //        List<AzureChatExtensionConfiguration> array = new List<AzureChatExtensionConfiguration>();
    //        foreach (var item in property.Value.EnumerateArray())
    //        {
    //            array.Add(AzureChatExtensionConfiguration.DeserializeAzureChatExtensionConfiguration(item, options));
    //        }
    //        dataSources = array;
    //        continue;
    //    }
    //}
}
