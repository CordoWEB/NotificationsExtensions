// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved



namespace NotificationsExtensions.Tiles
{
    /// <summary>
    /// Controls the horizontal alignment of text.
    /// </summary>
    public enum TileTextAlign
    {
        /// <summary>
        /// Default value. The system automatically decides the alignment based on the language and culture.
        /// </summary>
        Auto,

        /// <summary>
        /// Horizontally align the text to the left.
        /// </summary>
        [EnumString("left")]
        Left,

        /// <summary>
        /// Horizontally align the text in the center.
        /// </summary>
        [EnumString("center")]
        Center,

        /// <summary>
        /// Horizontally align the text to the right.
        /// </summary>
        [EnumString("right")]
        Right
    }
}