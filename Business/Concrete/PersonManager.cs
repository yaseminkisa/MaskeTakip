using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //çıplak class kalmasın

    //class lar özellik ve operasyonları tutmak için de kullanılır ancak özellik ve operasyon aynı class ta yazılmaz ayrı class lar olması gerekir
    //iş sınıfı
    public class PersonManager:IApplicantService
    {
        //encapsulation
        public void ApplyForMask(Person person)
        {
            
        }

        public List<Person> GetList() 
        {
            return null;
        }
        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return  client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
