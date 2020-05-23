using MyPhotosP2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMyPhotosP2
{
    public class APIP2
    {
        public ModelDBContainer context;
        public APIP2()
        {
            this.context = new ModelDBContainer();
        }
        //metoda care preia path ul dat de utilizator si il pune in baza de date
        public void PreluarePoza(string path)
        {
            int maxId = 0;
            string ok = "3";
            List<string> photoExtension = new List<string>() { ".tif", ".jpg", ".gif", ".png" };
            List<string> videoExtension = new List<string>() { ".avchid", ".avi", ".flv", ".mkv", ".mov", ".mp4" };
            string extension = Path.GetExtension(path).ToLower();
            if (context.Media.Count() == 0)
                maxId = 0;
            else
                maxId = context.Media.Max(a => a.Id);
            if (photoExtension.Contains(extension))
                ok = "0";
            else if (videoExtension.Contains(extension))
                ok = "1";
            if (!ok.Equals("3"))
            {
                Media media = new Media()
                {
                    Id = maxId + 1,
                    Path = path,
                    PozaSauVideo = ok,
                    Sters = "0"
                };
                context.Media.Add(media);
                context.SaveChanges();
            }
        }
        public void AdaugaProprietate(string path, string nume, string valoare)
        {
            Proprietati p = new Proprietati();
            int exista = 0;
            foreach (Proprietati prop in context.Proprietatis)
            {
                if (prop.NumeCamp.Equals(nume) && prop.ValoareCamp.Equals(valoare))
                {
                    exista = 1;
                    p = prop;
                }
            }
            var result = context.Media.FirstOrDefault(a => a.Path == path);
            if (result != null)
            {
                if (exista == 0)
                {
                    Proprietati proprietate = new Proprietati()
                    {
                        Id = MaxIdProp() + 1,
                        NumeCamp = nume,
                        ValoareCamp = valoare
                    };
                    result.Proprietatis.Add(proprietate);
                    context.SaveChanges();
                }
                else if (exista == 1)
                {
                    result.Proprietatis.Add(p);
                    context.SaveChanges();
                }
            }
        }
        public void StergeProprietate(string path, string nume, string valoare)
        {
            var result = context.Media.FirstOrDefault(a => a.Path == path);
            if (result != null)
            {
                foreach (Proprietati prop in result.Proprietatis)
                {
                    if (prop.NumeCamp.Equals(nume) && prop.ValoareCamp.Equals(valoare))
                    {
                        result.Proprietatis.Remove(prop);
                        break;
                    }
                }
                context.SaveChanges();
            }
        }

        public void SchimbaProprietate(string nume, string valoare)
        {
            var result = context.Proprietatis.FirstOrDefault(a => a.NumeCamp == nume);
            if (result != null)
            {
                result.ValoareCamp = valoare;
                context.SaveChanges();
            }
        }

        public void StergePoza(string path)
        {
            var result = context.Media.FirstOrDefault(a => a.Path == path);
            if (result != null)
            {
                result.Sters = "1";
                context.SaveChanges();
            }
        }

        public List<DTO> Cautare(string nume, string valoare)
        {
            List<DTO> gasite = new List<DTO>();

            var result = context.Proprietatis.FirstOrDefault(a => a.NumeCamp == nume && a.ValoareCamp == valoare);
            if (result != null)
            {
                context.Entry(result).Collection(r=>r.Media).Load();
                foreach (Media media in result.Media)
                {
                    DTO dto = new DTO()
                    {
                        Id = media.Id,
                        Path = media.Path,
                        PozaSauVideo = media.PozaSauVideo,
                        Sters = media.Sters
                    };
                    gasite.Add(dto);
                }
            }
            return gasite;
        }

        public List<Proprietati> CautarePropPhoto(int id)
        {
            List<Proprietati> gasite = new List<Proprietati>();

            var result = context.Media.FirstOrDefault(a => a.Id == id);
            if (result != null)
            {
                context.Entry(result).Collection(r => r.Proprietatis).Load();
                foreach (Proprietati p in result.Proprietatis)
                {
                    gasite.Add(p);
                }
            }
            return gasite;
        }


        public List<DTO> GetAllPhotos()
        {
            List<DTO> gasite = new List<DTO>();

            var result = context.Media.ToList();
            foreach(Media media in result)
            {
                DTO dto = new DTO()
                {
                    Id = media.Id,
                    Path = media.Path,
                    PozaSauVideo = media.PozaSauVideo,
                    Sters = media.Sters
                };
                gasite.Add(dto);
            }
          
            
            return gasite;
        }

        public List<Proprietati> GetAllProp()
        {
            List<Proprietati> gasite = new List<Proprietati>();

            var result = context.Proprietatis.ToList();
            foreach (Proprietati prop in result)
            {
                gasite.Add(prop);
            }


            return gasite;
        }


        public int MaxIdMedia()
        {
            int maxId = 0;
            if (context.Media.Count() == 0)
                maxId = 0;
            else
                maxId = context.Media.Max(a => a.Id) + 1;
            return maxId;
        }
        public int MaxIdProp()
        {
            int maxId = 0;
            if (context.Proprietatis.Count() == 0)
                maxId = 0;
            else
                maxId = context.Proprietatis.Max(a => a.Id) + 1;
            return maxId;
        }
    }
}
