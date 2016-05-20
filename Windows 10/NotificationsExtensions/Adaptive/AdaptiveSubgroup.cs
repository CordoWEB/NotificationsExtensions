﻿using NotificationsExtensions.Adaptive.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationsExtensions
{
    /// <summary>
    /// Subgroups are vertical columns that can contain text and images.
    /// </summary>
    public sealed class AdaptiveSubgroup
    {
        /// <summary>
        /// Initializes a new subgroup. Subgroups are vertical columns that can contain text and images.
        /// </summary>
        public AdaptiveSubgroup() { }

        /// <summary>
        /// <see cref="AdaptiveText"/> and <see cref="AdaptiveImage"/> are valid children of subgroups.
        /// </summary>
        public IList<IAdaptiveSubgroupChild> Children { get; private set; } = new List<IAdaptiveSubgroupChild>();

        private int? _hintWeight;

        /// <summary>
        /// Control the width of this subgroup column by specifying the weight, relative to the other subgroups.
        /// </summary>
        public int? HintWeight
        {
            get { return _hintWeight; }
            set
            {
                Element_AdaptiveSubgroup.CheckWeight(value);

                _hintWeight = value;
            }
        }

        /// <summary>
        /// Control the vertical alignment of this subgroup's content.
        /// </summary>
        public AdaptiveSubgroupTextStacking HintTextStacking { get; set; } = Element_AdaptiveSubgroup.DEFAULT_TEXT_STACKING;

        internal Element_AdaptiveSubgroup ConvertToElement()
        {
            var subgroup = new Element_AdaptiveSubgroup()
            {
                Weight = HintWeight,
                TextStacking = HintTextStacking
            };

            foreach (var child in Children)
            {
                subgroup.Children.Add(ConvertToSubgroupChildElement(child));
            }

            return subgroup;
        }

        private static IElement_AdaptiveSubgroupChild ConvertToSubgroupChildElement(IAdaptiveSubgroupChild child)
        {
            if (child is AdaptiveText)
                return (child as AdaptiveText).ConvertToElement();

            else if (child is AdaptiveImage)
                return (child as AdaptiveImage).ConvertToElement();

            else
                throw new NotImplementedException("Unknown child: " + child.GetType());
        }
    }
}
