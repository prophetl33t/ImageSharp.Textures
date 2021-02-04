// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.Textures.Formats.Dds.Processing.BlockFormats;

namespace SixLabors.ImageSharp.Textures.Formats.Dds.Processing
{
    public struct Bgr32 : IBlock<Bgr32>
    {
        /// <inheritdoc/>
        public int BitsPerPixel => 32;

        /// <inheritdoc/>
        public byte PixelDepthBytes => 4;

        /// <inheritdoc/>
        public byte DivSize => 1;

        /// <inheritdoc/>
        public byte CompressedBytesPerBlock => 4;

        /// <inheritdoc/>
        public bool Compressed => false;

        /// <inheritdoc/>
        public Image GetImage(byte[] blockData, int width, int height)
        {
            byte[] decompressedData = this.Decompress(blockData, width, height);
            return Image.LoadPixelData<ImageSharp.Textures.PixelFormats.Bgr32>(decompressedData, width, height);
        }

        /// <inheritdoc/>
        public byte[] Decompress(byte[] blockData, int width, int height)
        {
            return blockData;
        }
    }
}
