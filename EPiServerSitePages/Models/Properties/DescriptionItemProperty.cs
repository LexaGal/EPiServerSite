using EPiServer.Core;
using EPiServer.PlugIn;
using EPiServerSitePages.Models.Blocks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace EPiServerSitePages.Models.Properties
{
    [PropertyDefinitionTypePlugIn]
    public class DescriptionItemProperty : PropertyLongString
    {
         public override Type PropertyValueType
         {
             get { return typeof(IEnumerable<DescriptionItem>); }
         }
      
         public override object Value
         {
             get
             {
                 var value = base.Value as string;
                 if (value == null) { return null; }
                 return JsonConvert.DeserializeObject<IEnumerable<DescriptionItem>>(value);
                 //JavaScriptSerializer serializer = new JavaScriptSerializer();
                 //return serializer.Deserialize(value, typeof(IEnumerable<DescriptionItem>));
             }
             set
             {
                 if (value is IEnumerable<DescriptionItem>)
                 {
                    JsonConvert.SerializeObject(value, Formatting.Indented,
                        new JsonSerializerSettings
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                     //JavaScriptSerializer serializer = new JavaScriptSerializer();
                     //base.Value = serializer.Serialize(value);
                 }
                 else { base.Value = value; }
             }
         }
     }
}