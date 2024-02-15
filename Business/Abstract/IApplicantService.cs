using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{

    //interface: belli metot imzalarını barındırırlar. Birbirinin alternatifi olan sistemlerin farklı implementasyon yapmalarını sağlar. Yani yabancı uyrukluyu farklı check  eder Türk vatandaşını ayrı. İkisinin kuralları farklıdır. interface ler referans tutucudur. 
    public interface IApplicantService //iş sınıflarının interface leri genellikle bu şekilde isimlendirilir. Bir class oluştururken önce interface ini oluşturmak gerekir. interface arayüz demek. PersonManager classı içindeki metotları buraya aldığımızda hata verir çünkü burada sadece metot imzası barındırılabilir. Aşağıdakiler metot imzasıdır. 
    {
        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);
    }
}
