using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationChain.Models
{
    public class File
    {
        //Default Constructor
        public File()
        {

        }

        /// <summary>
        /// Constructors 
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="_content"></param>
        /// <param name="_secphase"></param>
        public File(int _id, byte[] _content, string _secphase)
        {
            Id = _id;
            Content = _content;
            SecPhase = _secphase;
        }

        /// <summary>
        /// Properties
        /// </summary>
        public int Id { get; set; }
        public byte[] Content { get; set; }
        public string SecPhase { get; set; }
    }
}
