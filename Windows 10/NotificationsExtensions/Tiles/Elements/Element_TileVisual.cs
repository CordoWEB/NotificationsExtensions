// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved


using System;
using System.Collections.Generic;

namespace NotificationsExtensions.Tiles
{
    [NotificationXmlElement("visual")]
    internal sealed class Element_TileVisual
    {
        internal const TileBranding DEFAULT_BRANDING = TileBranding.Auto;
        internal const bool DEFAULT_ADD_IMAGE_QUERY = false;

        [NotificationXmlAttribute("addImageQuery")]
        public bool? AddImageQuery { get; set; }

        [NotificationXmlAttribute("baseUri")]
        public Uri BaseUri { get; set; }

        [NotificationXmlAttribute("branding", DEFAULT_BRANDING)]
        public TileBranding Branding { get; set; } = DEFAULT_BRANDING;

        [NotificationXmlAttribute("contentId")]
        public string ContentId { get; set; }

        [NotificationXmlAttribute("displayName")]
        public string DisplayName { get; set; }

        [NotificationXmlAttribute("lang")]
        public string Language { get; set; }

        [NotificationXmlAttribute("version")]
        public int? Version { get; set; }

        [NotificationXmlAttribute("arguments")]
        public string Arguments { get; set; }

        public IList<Element_TileBinding> Bindings { get; private set; } = new List<Element_TileBinding>();
    }
}