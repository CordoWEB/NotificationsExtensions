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
    /// A selection box control, which lets users pick from a dropdown list of options.
    /// </summary>
    public sealed class ToastSelectionBox : IToastInput
    {
        /// <summary>
        /// Constructs a new toast SelectionBox input control with the required elements.
        /// </summary>
        /// <param name="id">Developer-provided ID that the developer uses later to retrieve input when the toast is interacted with.</param>
        public ToastSelectionBox(string id)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            Id = id;
        }

        /// <summary>
        /// The ID property is required, and is used so that developers can retrieve user input once the app is activated.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Title text to display above the SelectionBox.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// This controls which item is selected by default, and refers to the Id property of <see cref="ToastSelectionBoxItem"/>. If you do not provide this, the default selection will be empty (user sees nothing).
        /// </summary>
        public string DefaultSelectionBoxItemId { get; set; }

        /// <summary>
        /// The selection items that the user can pick from in this SelectionBox. Only 5 items can be added.
        /// </summary>
        public IList<ToastSelectionBoxItem> Items { get; private set; } = new LimitedList<ToastSelectionBoxItem>(5);

        internal Element_ToastInput ConvertToElement()
        {
            var input = new Element_ToastInput()
            {
                Type = ToastInputType.Selection,
                Id = Id,
                DefaultInput = DefaultSelectionBoxItemId,
                Title = Title
            };

            foreach (var item in Items)
                input.Children.Add(item.ConvertToElement());

            return input;
        }
    }


}