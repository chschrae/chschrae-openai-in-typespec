﻿using OpenAI.Internal;
using System;
using System.ClientModel.Primitives;
using System.IO;

namespace OpenAI.Images;

/// <summary>
/// Represents additional options available to control the behavior of an image generation operation.
/// </summary>
public partial class ImageEditOptions
{
    /// <inheritdoc cref="Internal.Models.CreateImageEditRequest.Mask"/>
    public BinaryData MaskBytes { get; set; }

    // The generator will need to add file-name to models for properties that
    // represent files in order to enable setting the header.
    /// <summary>
    /// TODO
    /// </summary>
    public string MaskFileName { get; set; }

    /// <inheritdoc cref="Internal.Models.CreateImageEditRequest.ResponseFormat"/>
    public ImageResponseFormat? ResponseFormat { get; set; }

    /// <inheritdoc cref="Internal.Models.CreateImageEditRequest.Size"/>
    public GeneratedImageSize Size { get; set; }

    /// <inheritdoc cref="Internal.Models.CreateImageEditRequest.User"/>
    public string User { get; set; }

    internal MultipartFormDataBinaryContent ToMultipartContent(Stream fileStream,
        string fileName,
        string prompt,
        string model,
        int? imageCount)
    {
        MultipartFormDataBinaryContent content = new();

        content.Add(fileStream, "image", fileName);

        AddContent(model, prompt, imageCount, content);

        return content;
    }

    internal MultipartFormDataBinaryContent ToMultipartContent(BinaryData imageBytes, 
        string fileName,
        string prompt,
        string model,
        int? imageCount)
    {
        MultipartFormDataBinaryContent content = new();

        content.Add(imageBytes, "image", fileName);

        AddContent(model, prompt, imageCount, content);

        return content;
    }

    private void AddContent(string model, string prompt, int? imageCount, MultipartFormDataBinaryContent content)
    {
        content.Add(prompt, "prompt");
        content.Add(model, "model");

        if (MaskBytes is not null)
        {
            content.Add(MaskBytes.ToArray(), "mask", MaskFileName);
        }

        if (imageCount is not null)
        {
            content.Add(imageCount.Value, "n");
        }

        if (ResponseFormat is not null)
        {
            string format = ResponseFormat switch
            {
                ImageResponseFormat.Uri => "url",
                ImageResponseFormat.Bytes => "b64_json",
                _ => throw new ArgumentException(nameof(ResponseFormat)),
            };

            content.Add(format, "response_format");
        }

        if (Size is not null)
        {
            string imageSize = ModelReaderWriter.Write(Size).ToString();
            content.Add(imageSize, "size");
        }

        if (User is not null)
        {
            content.Add(User, "user");
        }
    }
}