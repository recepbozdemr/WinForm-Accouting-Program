using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HeraSatis.Entities.Context;
using HeraSatis.Entities.Tables;

namespace HeraSatis.Entities.DataAccess
{
   public class StokDAL
    {

        public void AddOrUpdate(HeraSatisContext context,Stok entity)
        {
            context.Stoklar.AddOrUpdate(entity);
        }
        public void Delete(HeraSatisContext context, Expression<Func<Stok, bool>> filter)
        {
            context.Stoklar.RemoveRange(context.Stoklar.Where(filter));
        }
        public void Save(HeraSatisContext context)
        {
            context.SaveChanges();
        }







    }
}
