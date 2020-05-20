using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosP2
{
    
    [DataContract(IsReference = true)]
    public class DTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public string PozaSauVideo { get; set; }
        [DataMember]
        public string Sters { get; set; }
    }
}
