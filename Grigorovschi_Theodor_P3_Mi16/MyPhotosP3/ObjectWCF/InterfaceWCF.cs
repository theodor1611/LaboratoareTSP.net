using MyPhotosP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF
{
    
        [ServiceContract]
        interface InterfaceApi
        {
            [OperationContract]
            void PreluarePoza(string path);

            [OperationContract]
            void AdaugaProprietate(string path, string nume, string valoare);

            [OperationContract]
            void StergeProprietate(string path, string nume, string valoare);

            [OperationContract]
            void SchimbaProprietate(string nume, string valoare);

            [OperationContract]
            void StergePoza(string path);

            [OperationContract]
            List<DTO> Cautare(string nume, string valoare);

            [OperationContract]
            List<DTO> GetAllPhotos();

            [OperationContract]
            List<Proprietati> GetAllProp();

            [OperationContract]
            List<Proprietati> CautarePropPhoto(int id);

            [OperationContract]
            int MaxIdMedia();

            [OperationContract]
            int MaxIdProp();
        }
    
}
