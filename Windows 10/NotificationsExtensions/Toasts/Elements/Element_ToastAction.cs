// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved



namespace NotificationsExtensions.Toasts
{
    [NotificationXmlElement("action")]
    internal sealed class Element_ToastAction : IElement_ToastActionsChild
    {
        internal const Element_ToastActivationType DEFAULT_ACTIVATION_TYPE = Element_ToastActivationType.Foreground;

        /// <summary>
        /// The text to be displayed on the button.
        /// </summary>
        [NotificationXmlAttribute("content")]
        public string Content { get; set; }

        /// <summary>
        /// The arguments attribute describes the app-defined data that the app can later retrieve once it is activated from user taking this action.
        /// </summary>
        [NotificationXmlAttribute("arguments")]
        public string Arguments { get; set; }

        [NotificationXmlAttribute("activationType", DEFAULT_ACTIVATION_TYPE)]
        public Element_ToastActivationType ActivationType { get; set; } = DEFAULT_ACTIVATION_TYPE;

        /// <summary>
        /// imageUri is optional and is used to provide an image icon for this action to display inside the button alone with the text content.
        /// </summary>
        [NotificationXmlAttribute("imageUri")]
        public string ImageUri { get; set; }

        /// <summary>
        /// This is specifically used for the quick reply scenario. 
        /// </summary>
        [NotificationXmlAttribute("hint-inputId")]
        public string InputId { get; set; }
    }

    internal enum Element_ToastActivationType
    {
        /// <summary>
        /// Default value. Your foreground app is launched.
        /// </summary>
        Foreground,

        /// <summary>
        /// Your corresponding background task (assuming you set everything up) is triggered, and you can execute code in the background (like sending the user's quick reply message) without interrupting the user.
        /// </summary>
        [EnumString("background")]
        Background,

        /// <summary>
        /// Launch a different app using protocol activation.
        /// </summary>
        [EnumString("protocol")]
        Protocol,

        /// <summary>
        /// System handles the activation.
        /// </summary>
        [EnumString("system")]
        System
    }
}