// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved

using System;
using System.Text;

namespace NotificationsExtensions.Tiles
{
    /// <summary>
    /// A text element on the tile.
    /// </summary>
    public sealed class TileBasicText
    {
        /// <summary>
        /// The text value that will be shown in the text field.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The target locale of the XML payload, specified as a BCP-47 language tags such as "en-US" or "fr-FR". The locale specified here overrides any other specified locale, such as that in binding or visual. If this value is a literal string, this attribute defaults to the user's UI language. If this value is a string reference, this attribute defaults to the locale chosen by Windows Runtime in resolving the string.
        /// </summary>
        public string Lang { get; set; }

        internal Element_TileText ConvertToElement()
        {
            return new Element_TileText()
            {
                Text = Text,
                Lang = Lang
            };
        }

        /// <summary>
        /// Returns the Text property value.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Text;
        }
    }
}