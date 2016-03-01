using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPiServerSitePages.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class KeyValueItemsAttribute : Attribute
    {
        public string KeyLabel { get; set; }
        public string ValueLabel { get; set; }
        public string AddButtonLabel { get; set; }
        public string RemoveButtonLabel { get; set; }
        public string KeyValidationExpression { get; set; }
        public string ValueValidationExpression { get; set; }
        public string KeyValidationMessage { get; set; }
        public string ValueValidationMessage { get; set; }

        public KeyValueItemsAttribute(string keyLabel,
                                        string valueLabel,
                                        string addButtonLabel,
                                        string removeButtonLabel,
                                        string keyValidationExpression,
                                        string keyValidationMessage,
                                        string valueValidationExpression,
                                        string valueValidationMessage)
        {
            KeyLabel = keyLabel;
            ValueLabel = valueLabel;
            AddButtonLabel = addButtonLabel;
            RemoveButtonLabel = removeButtonLabel;
            KeyValidationExpression = keyValidationExpression;
            KeyValidationMessage = keyValidationMessage;
            ValueValidationExpression = valueValidationExpression;
            ValueValidationMessage = valueValidationMessage;
        }
    }
}