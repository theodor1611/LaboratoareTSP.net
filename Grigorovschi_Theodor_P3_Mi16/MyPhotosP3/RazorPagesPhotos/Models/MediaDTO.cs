using ServiceReferencePhotos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesPhotos.Models
{
    public class MediaDTO
    {
        public int Id { get; set; }
        
        public string Path { get; set; }
        
        public string PozaSauVideo { get; set; }
        
        public string Sters { get; set; }


        public List<Proprietati> Proprietatis { get; set; } = new List<Proprietati>();
    }
}
