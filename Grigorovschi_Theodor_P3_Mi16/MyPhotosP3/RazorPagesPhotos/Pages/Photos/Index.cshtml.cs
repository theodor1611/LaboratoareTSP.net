using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesPhotos.Models;
using ServiceReferencePhotos;

namespace RazorPagesPhotos.Pages.Photos
{
    public class IndexModel : PageModel
    {
        InterfaceApiClient client = new InterfaceApiClient();
        public List<MediaDTO> Medias { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Prop { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        
        [BindProperty(SupportsGet = true)]
        public string ValoareC { get; set; }
        public SelectList P { get; set; }

        public IndexModel()
        {
            Medias = new List<MediaDTO>();
        }
        public async Task OnGetAsync()
        {
            var m = await client.GetAllPhotosAsync();
            var toateprop = await client.GetAllPropAsync();
            List<string> Name = new List<string>();
            foreach(var i in toateprop)
            {
                Name.Add(i.NumeCamp);
            }
            P = new SelectList(Name);
            foreach (var item in m)
            {
                MediaDTO dto = new MediaDTO();
                dto.Id = item.Id;
                dto.Path = item.Path;
                dto.PozaSauVideo = item.PozaSauVideo;
                dto.Sters = item.Sters;
                List<Proprietati> p = new List<Proprietati>();
                p = await client.CautarePropPhotoAsync(item.Id);
                if (p.Count != 0) { 
                foreach(var prop in p)
                {
                    dto.Proprietatis.Add(prop);
                }
                }
                Medias.Add(dto);
            }
            if(!string.IsNullOrEmpty(Prop) && !string.IsNullOrEmpty(ValoareC))
            {
                Medias.Clear();
                var c = await client.CautareAsync(Prop, ValoareC);
                foreach (var item2 in c)
                {
                    MediaDTO dto = new MediaDTO();
                    dto.Id = item2.Id;
                    dto.Path = item2.Path;
                    dto.PozaSauVideo = item2.PozaSauVideo;
                    dto.Sters = item2.Sters;
                    List<Proprietati> p = new List<Proprietati>();
                    p = await client.CautarePropPhotoAsync(item2.Id);
                    if (p.Count != 0)
                    {
                        foreach (var prop in p)
                        {
                            dto.Proprietatis.Add(prop);
                        }
                    }
                    Medias.Add(dto);
                }
            }
            ViewData["Cautare"] = Medias.Count().ToString();
        }
    }
}