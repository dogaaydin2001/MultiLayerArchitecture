using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OperationClaimManager : IOperationClaimService
    {
        private readonly IOperationClaimDal _operationClaimDal;

        //constructer içinde aslında interface için bir new'leme yaptık 
        //programda bu class çağırılınca ilk constructer çalışır ve new'leme yapar
        //programda ağırlık yapmamış olur
        public OperationClaimManager(IOperationClaimDal operationClaimDal)
        {
            _operationClaimDal = operationClaimDal;
        }
        public void Add(OperationClaim operationClaim)
        {
            //add methodu data acces layerdan geliyor
            _operationClaimDal.Add(operationClaim);
        }
    }
}

//class yerine interface kullandık çünkü class kullanılsaydı her seferinde newlemek gerekirdi 
//interface'i çağırmak için(classta çağırma işlemini yapabilmek için new yapıyoruz) interface'e değişken atadığımızda karşılığı null oluyor
//interface'i null olarak çağıracağımız için program bize hata verirdi
//interfacein karşılığını göstermem gerek = constructer kullanarak gösterebiliriz

//