using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPhotos.Models;
using ServiceReferencePhotos;

namespace RazorPagesPhotos.Pages.ProprietatiPoze
{
    public class AfisareProprietatiModel : PageModel
    {
        InterfaceApiClient client = new InterfaceApiClient();
        public List<ProprietatiDTO> Proprietatis { get; set; }
        public AfisareProprietatiModel()
        {
            Proprietatis = new List<ProprietatiDTO>();
        }
        public async Task OnGetAsync(int? id)
        {
            if (!id.HasValue)
                return;
            var item = await client.CautarePropPhotoAsync(id.Value);
            ViewData["Photo"] = id.ToString();
            foreach (var p in item)
            {
                ProprietatiDTO prop = new ProprietatiDTO();
                prop.Id = p.Id;
                prop.NumeCamp = p.NumeCamp;
                prop.ValoareCamp = p.ValoareCamp;
                Proprietatis.Add(prop);
            }
        }
    }
}