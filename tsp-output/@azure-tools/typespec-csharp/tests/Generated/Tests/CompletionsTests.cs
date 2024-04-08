// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using NUnit.Framework;

namespace OpenAI.Tests
{
    public partial class CompletionsTests
    {
        [Test]
        [Ignore("Compilation test only")]
        public void SmokeTest()
        {
            ApiKeyCredential credential = new ApiKeyCredential(Environment.GetEnvironmentVariable("OpenAIClient_KEY"));
            Completions client = new OpenAIClient(credential).GetCompletionsClient();
            Assert.IsNotNull(client);
        }
    }
}
