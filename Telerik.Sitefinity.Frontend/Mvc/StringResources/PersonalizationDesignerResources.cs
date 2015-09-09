﻿using Telerik.Sitefinity.Localization;

namespace Telerik.Sitefinity.Frontend.Mvc.StringResources
{
    /// <summary>
    /// Localizable strings for the Personalization's designer.
    /// </summary>
    [ObjectInfo(typeof(PersonalizationDesignerResources), Title = "PersonalizationResourcesTitle", Description = "PersonalizationDesignerResourcesDescription")]
    public class PersonalizationDesignerResources : Resource
    {
        /// <summary>
        /// Title for the personalization designer resources class.
        /// </summary>
        /// <value>Personalization designer resources</value>
        [ResourceEntry("PersonalizationResourcesTitle",
            Value = "Personalization designer resources",
            Description = "Title for the personalization designer resources class.",
            LastModified = "2015/09/09")]
        public string PersonalizationResourcesTitle
        {
            get
            {
                return this["PersonalizationResourcesTitle"];
            }
        }

        /// <summary>
        /// Localizable strings for the Personalization designer
        /// </summary>
        [ResourceEntry("PersonalizationDesignerResourcesDescription",
            Value = "Localizable strings for the Personalizartion designer.",
            Description = "Localizable strings for the Personalization designer",
            LastModified = "2015/09/09")]
        public string PersonalizationDesignerResourcesDescription
        {
            get
            {
                return this["PersonalizationDesignerResourcesDescription"];
            }
        }

        /// <summary>
        /// Error!
        /// </summary>
        [ResourceEntry("Error",
            Value = "Error!",
            Description = "Error!",
            LastModified = "2015/09/09")]
        public string Error
        {
            get
            {
                return this["Error"];
            }
        }

        /// <summary>
        /// Cancel
        /// </summary>
        [ResourceEntry("Cancel",
            Value = "Cancel",
            Description = "Cancel",
            LastModified = "2015/09/09")]
        public string Cancel
        {
            get
            {
                return this["Cancel"];
            }
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <value>Add</value>
        [ResourceEntry("Add",
            Value = "Add",
            Description = "Add",
            LastModified = "2015/09/09")]
        public string Add
        {
            get
            {
                return this["Add"];
            }
        }

        /// <summary>
        /// Caption for personalization dialog window
        /// </summary>
        /// <value>Add personalizaed version of this widget</value>
        [ResourceEntry("PersonalizationDialogCaption",
            Value = "Add personalizaed version of this widget",
            Description = "Caption for personalization dialog window",
            LastModified = "2015/09/09")]
        public string PersonalizationDialogCaption
        {
            get
            {
                return this["PersonalizationDialogCaption"];
            }
        }

        /// <summary>
        /// Segments label for personalization dialog window
        /// </summary>
        /// <value>Which user segment is this personalized version for?</value>
        [ResourceEntry("PersonalizationSegmentsLabel",
            Value = "Which user segment is this personalized version for?",
            Description = "Segments label for personalization dialog window",
            LastModified = "2015/09/09")]
        public string PersonalizationSegmentsLabel
        {
            get
            {
                return this["PersonalizationSegmentsLabel"];
            }
        }
    }
}
