using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationChain.Models
{
    public class File
    {
        public int Id { get; set; }
        public byte[] Content { get; set; }
        public string SecPhase { get; set; }
    }
}
