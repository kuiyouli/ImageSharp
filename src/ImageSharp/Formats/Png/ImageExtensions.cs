﻿// <copyright file="ImageExtensions.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp
{
    using System.IO;

    using Formats;

    using ImageSharp.PixelFormats;

    /// <summary>
    /// Extension methods for the <see cref="Image{TPixel}"/> type.
    /// </summary>
    public static partial class ImageExtensions
    {
        /// <summary>
        /// Saves the image to the given stream with the png format.
        /// </summary>
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="stream">The stream to save the image to.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if the stream is null.</exception>
        public static void SaveAsPng<TPixel>(this Image<TPixel> source, Stream stream)
            where TPixel : struct, IPixel<TPixel>
                => SaveAsPng(source, stream, null);

        /// <summary>
        /// Saves the image to the given stream with the png format.
        /// </summary>
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="stream">The stream to save the image to.</param>
        /// <param name="encoder">The options for the encoder.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if the stream is null.</exception>
        public static void SaveAsPng<TPixel>(this Image<TPixel> source, Stream stream, PngEncoder encoder)
            where TPixel : struct, IPixel<TPixel>
            => source.Save(stream, encoder ?? source.Configuration.FindEncoder(ImageFormats.Png));
    }
}
