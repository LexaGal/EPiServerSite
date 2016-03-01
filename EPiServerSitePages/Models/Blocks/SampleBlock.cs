using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiSS.Models.Blocks
{
    [ContentType]
    public class SampleBlock : BlockData
    {
        public virtual PageReference Root { get; set; }
        public virtual int Count { get; set; }
        public virtual string Heading { get; set; }
    }
    
}