using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using EPiServerSitePages.Models.Attributes;
using EPiServerSitePages.Models.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPiServerSitePages.Models.EditorDescriptors
{
    [EditorDescriptorRegistration(TargetType = typeof(IEnumerable<DescriptionItem>))]
    public class KeyValueItemsEditorDescriptor : EditorDescriptor
    {
        public KeyValueItemsEditorDescriptor()
        {
            ClientEditingClass = "episerver75.editors.KeyValueItems";
        }

        protected override void SetEditorConfiguration(ExtendedMetadata metadata)
        {
            var keyValueItemsAttribute = metadata.Attributes.FirstOrDefault(a => typeof(KeyValueItemsAttribute) == a.GetType()) as KeyValueItemsAttribute;
            if (keyValueItemsAttribute != null)
            {
                if (!String.IsNullOrEmpty(keyValueItemsAttribute.KeyLabel))
                    EditorConfiguration["keyLabel"] = keyValueItemsAttribute.KeyLabel;
                if (!String.IsNullOrEmpty(keyValueItemsAttribute.ValueLabel))
                    EditorConfiguration["valueLabel"] = keyValueItemsAttribute.ValueLabel;
                if (!String.IsNullOrEmpty(keyValueItemsAttribute.AddButtonLabel))
                    EditorConfiguration["addButtonLabel"] = keyValueItemsAttribute.AddButtonLabel;
                if (!String.IsNullOrEmpty(keyValueItemsAttribute.RemoveButtonLabel))
                    EditorConfiguration["removeButtonLabel"] = keyValueItemsAttribute.RemoveButtonLabel;
                if (!String.IsNullOrEmpty(keyValueItemsAttribute.KeyValidationExpression))
                    EditorConfiguration["keyValidationExpression"] = keyValueItemsAttribute.KeyValidationExpression;
                if (!String.IsNullOrEmpty(keyValueItemsAttribute.KeyValidationMessage))
                    EditorConfiguration["keyValidationMessage"] = keyValueItemsAttribute.KeyValidationMessage;
                if (!String.IsNullOrEmpty(keyValueItemsAttribute.ValueValidationExpression))
                    EditorConfiguration["valueValidationExpression"] = keyValueItemsAttribute.ValueValidationExpression;
                if (!String.IsNullOrEmpty(keyValueItemsAttribute.ValueValidationMessage))
                    EditorConfiguration["valueValidationMessage"] = keyValueItemsAttribute.ValueValidationMessage;
            }
            base.SetEditorConfiguration(metadata);
        }
    }
}