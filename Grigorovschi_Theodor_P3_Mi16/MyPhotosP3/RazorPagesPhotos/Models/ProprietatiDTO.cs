using ServiceReferencePhotos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesPhotos.Models
{
    public class ProprietatiDTO
    {
        public int Id { get; set; }
        
        public string NumeCamp { get; set; }
        
        public string ValoareCamp { get; set; }

        public List<Media> Media { get; set; } = new List<Media>();
    }
}
