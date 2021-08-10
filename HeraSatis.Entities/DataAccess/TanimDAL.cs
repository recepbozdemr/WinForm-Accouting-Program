using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeraSatis.Entities.Context;
using HeraSatis.Entities.Repositories;
using HeraSatis.Entities.Tables;
using HeraSatis.Entities.Validations;

namespace HeraSatis.Entities.DataAccess
{
  public  class TanimDAL: EntityRepositoryBase<HeraSatisContext, Tanim,TanimValidator>
    {
    }
}
