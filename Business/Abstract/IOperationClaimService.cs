using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOperationClaimService
    {
        //ihtiyacımız oldukça bunu kullanacağız eklemeler yapacağız
        //data access katmanında generic yapı kurabildiğimiz için tüm methodları yazmıştık
        //fakat burada generic bir karşılığı yok
        //tüm methodları ekleme işlemi yapsak bile tüm methodların ekleme işleminin generic bir yapıya taşıyıp oradan otomatik çekemiyoruz
        //çünkü her bir methodun kendine ait business katmanında bir kontrol karşılığı olacak
        void Add(OperationClaim operationClaim);
    }
}

//kullanıcı kayıt yapar
// web api katmanı business a kayıt yapmak istediğini söyler
// business katmanı kayıtla alakalı yapacağı kontrol varsa kontrolü yapar eğer sorun yoksa
// data access katmanına kayıt yapmak istediğini söyler bu kayıdı yap der
// data access businessa kayıt yapıldı der haber eder
// business tan biz web api katmanına haber verir.
//kontrol varsa kontrol yap sonra data access katmanına kayıt işlemi yap der
//anlamak için OperationClaimManager'a git
