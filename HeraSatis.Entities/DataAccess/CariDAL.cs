using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HeraSatis.Entities.Context;
using HeraSatis.Entities.Interfaces;
using HeraSatis.Entities.Repositories;
using HeraSatis.Entities.Tables;
using HeraSatis.Entities.Validations;

namespace HeraSatis.Entities.DataAccess
{
    public class CariDAL:EntityRepositoryBase<HeraSatisContext,Cari,CariValidator>
    {
    
    }
}
