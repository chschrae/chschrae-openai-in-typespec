﻿using NUnit.Framework;
using OpenAI.Images;
using System;
using System.IO;

namespace OpenAI.Samples
{
    public partial class ImageSamples
    {
        [Test]
        [Ignore("Compilation validation only")]
        public void Sample01_SimpleImage()
        {
            ImageClient client = new("dall-e-3", Environment.GetEnvironmentVariable("OpenAIClient_KEY"));

            string prompt = "The concept for a living room that blends Scandinavian simplicity with Japanese minimalism for"
                + " a serene and cozy atmosphere. It's a space that invites relaxation and mindfulness, with natural light"
                + " and fresh air. Using neutral tones, including colors like white, beige, gray, and black, that create a"
                + " sense of harmony. Featuring sleek wood furniture with clean lines and subtle curves to add warmth and"
                + " elegance. Plants and flowers in ceramic pots adding color and life to a space. They can serve as focal"
                + " points, creating a connection with nature. Soft textiles and cushions in organic fabrics adding comfort"
                + " and softness to a space. They can serve as accents, adding contrast and texture.";

            ImageGenerationOptions options = new()
            {
                Quality = ImageQuality.High,
                Size = ImageSize.Size1792x1024,
                Style = ImageStyle.Vivid,
                ResponseFormat = ImageResponseFormat.Bytes
            };

            GeneratedImage generatedImage = client.GenerateImage(prompt, options);
            using Stream image = generatedImage.Image;

            using FileStream stream = File.OpenWrite($"{Guid.NewGuid()}.png");
            image.CopyTo(stream);
        }
    }
}
