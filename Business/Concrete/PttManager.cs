using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {


        //eğer bir iş sınıf başka bir iş sınıfı kullanırken (entity ler için geçerli değil iş sınıfı ve erişim sınıfı dediğimiz sınıflar için) new liyorsa ileriye dönük bu yazılımda değişiklik talebi geldiğinde  bu uygulama direnç gösterir. Yani PersonManager ı new lediğimizde artık buna bağımlıyız demektir. Daha sonra örneğin sadece PersonManager a yani kendi vatandaşlarına değil vatandaş olmayalara da maske verilecek ama şuan GiveMask sadece vatandaşa bağlı. Bu doğru bir sistem değil

        private IApplicantService _applicantService;//pttManagerin bağımlı olduğu sınıf yerine o sınıfların interface ini yazıyoruz. Bunlar string ad gibi bir field. Bu field lar class içinde "_" ile yazılır.

        public PttManager(IApplicantService applicantService) //Constructor yapısı (oluşturucu). PttManager new yapıldığında bu blok önce çalışır. Oluşturduğu zaman parametre olarak aday servisi vermek gerekir
        {
            _applicantService = applicantService;//class larda fieldların _ ile başlamasının sebebi budur. constructor dan set edelir.
        }
        public void GiveMask(Person person)
        {
            //PttManager pttManager=new PttManager(new ForeignerManager());
            //PttManager pttManager = new PttManager(new PersonManager());
            if (_applicantService.CheckPerson(person)) 
            {
                Console.WriteLine(person.FirstName + " için maske verildi" );
            }
        }
    }
}
