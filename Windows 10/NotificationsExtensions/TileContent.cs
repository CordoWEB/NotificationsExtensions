// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved

using System;
using System.Text;
#if !WINRT_NOT_PRESENT
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
#endif

namespace NotificationsExtensions
{
    /// <summary>
    /// Base tile element, which contains a single visual element.
    /// </summary>
    public sealed class TileContent
    {
        /// <summary>
        /// The visual element is required.
        /// </summary>
        public TileVisual Visual { get; set; }

        public string GetXml()
        {
            return ConvertToElement().GetXml();
        }

        public Element_Tile ConvertToElement()
        {
            var tile = new Element_Tile();

            if (Visual != null)
                tile.Visual = Visual.ConvertToElement();

            return tile;
        }
    }
}