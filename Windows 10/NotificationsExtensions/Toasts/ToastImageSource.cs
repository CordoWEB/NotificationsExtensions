// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
#if !WINRT_NOT_PRESENT
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
#endif

namespace NotificationsExtensions.Toasts
{
    /// <summary>
    /// Defines a toast image source and related properties.
    /// </summary>
    public sealed class ToastImageSource
    {
        /// <summary>
        /// Constructs an image source with all the required properties.
        /// </summary>
        /// <param name="src">The URI of the image source. Can be from your application package, application data, or the internet.</param>
        public ToastImageSource(string src)
        {
            if (src == null)
                throw new ArgumentNullException("src");

            Src = src;
        }

        /// <summary>
        /// The URI of the image source. Can be from your application package, application data, or the internet.
        /// </summary>
        public string Src { get; private set; }

        /// <summary>
        /// A description of the image, for users of assistive technologies.
        /// </summary>
        public string Alt { get; set; }

        /// <summary>
        /// Set to true to allow Windows to append a query string to the image URI supplied in the tile notification. Use this attribute if your server hosts images and can handle query strings, either by retrieving an image variant based on the query strings or by ignoring the query string and returning the image as specified without the query string. This query string specifies scale, contrast setting, and language.
        /// </summary>
        public bool AddImageQuery { get; set; } = Element_ToastImage.DEFAULT_ADD_IMAGE_QUERY;

        internal Element_ToastImage ConvertToElement()
        {
            Element_ToastImage image = new Element_ToastImage();

            PopulateElement(image);

            return image;
        }

        internal void PopulateElement(Element_ToastImage image)
        {
            image.Src = Src;
            image.Alt = Alt;
            image.AddImageQuery = AddImageQuery;
        }

        /// <summary>
        /// Returns the value of the Src property.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Src;
        }
    }


}