using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationChain.Models
{
    [Table("DocumentationTable")]
    public class DocumentationTable
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string SecuirtyPhase { get; set; }
    }
}
