using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryMyPhotosP2;
using MyPhotosP2;

namespace ObjectWCF
{
    public class Service : InterfaceApi
    {
        public void AdaugaProprietate(string path, string nume, string valoare)
        {
            APIP2 api = new APIP2();
            api.AdaugaProprietate(path, nume, valoare);
        }

        public List<DTO> Cautare(string nume, string valoare)
        {
            APIP2 api = new APIP2();
            return api.Cautare(nume, valoare);
        }

        public List<DTO> GetAllPhotos()
        {
            APIP2 api = new APIP2();
            return api.GetAllPhotos();
        }

        public List<Proprietati> GetAllProp()
        {
            APIP2 api = new APIP2();
            return api.GetAllProp();
        }

        public List<Proprietati> CautarePropPhoto(int id)
        {
            APIP2 api = new APIP2();
            return api.CautarePropPhoto(id);
        }

        public int MaxIdMedia()
        {
            APIP2 api = new APIP2();
            return api.MaxIdMedia();
        }

        public int MaxIdProp()
        {
            APIP2 api = new APIP2();
            return api.MaxIdProp();
        }

        public void PreluarePoza(string path)
        {
            APIP2 api = new APIP2();
            api.PreluarePoza(path);
        }

        public void SchimbaProprietate(string nume, string valoare)
        {
            APIP2 api = new APIP2();
            api.SchimbaProprietate(nume, valoare);
        }

        public void StergePoza(string path)
        {
            APIP2 api = new APIP2();
            api.StergePoza(path);
        }

        public void StergeProprietate(string path, string nume, string valoare)
        {
            APIP2 api = new APIP2();
            api.StergeProprietate(path, nume, valoare);
        }
    }
}
