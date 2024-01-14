using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationClaimsController : ControllerBase
    {
        private readonly IOperationClaimService _operationClaimService;

        public OperationClaimsController(IOperationClaimService operationClaimService)
        {
            _operationClaimService = operationClaimService;
        }

        [HttpPost("add")]
        public IActionResult Add(OperationClaim operationClaim)
        {
            _operationClaimService.Add(operationClaim);
            return Ok("Kayıt işlemi başarıyla tamamlandı");
        }

    }
}
 //programı çalıştırıp baktığımda kayıt yapma işlemi bana 500 döndürdü ve IOperationClaimService'in karşılığını bulamadı
 //dependency hatası aldım
 //add'e f12 ile geldiğimde IOperationClaime ulaştım onun imzasına geldim tekrar f12 yapıp adde tıkladığımda ulaşamıyorum başka bir yere 
 //çünkü classa implement olmuş durumda yani adde sağ tıklayıp implemente git demem gerekki ulaşabileyim
 //programa IOperationClaimService'in OperationClaimManager ile bağlantılı demek gerek şu an bulamıyor
 //dependency injection yapacağız
 //biz class kullanmayarak interface kullanarak yük yapmadan interfacete constructer kullanarak çağırdığımızdan 
 //kullandığımız interface in karşılığı class ı belirtmelyiz bu da ancak dependency ile oluyor.

