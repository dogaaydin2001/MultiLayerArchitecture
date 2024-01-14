using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserOperationClaim
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperatiınClaimId { get; set; }
    }
}

// didnt use code first it would be easier but i didnt want to be depend to code first
// didnt want to force classes to depend in each other (code first)
// scaffold-dbcontext: first create db then use on a project (database first)
// less dependency is more