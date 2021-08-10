using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HeraSatis.Entities.Interfaces;
using HeraSatis.Entities.Tools;
namespace HeraSatis.Entities.Repositories
{
   public class EntityRepositoryBase<TContext, TEntity,TValidator>:IEntityRepository<TContext,TEntity> 
       where TContext : DbContext, new()
       where TEntity : class, IEntity, new()
       where TValidator : IValidator, new()
    {
        public List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null)
        {

            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();  //Çoklu kayıt döndürmek için kullanılan method

        }

        public TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter)
        {

            return context.Set<TEntity>().SingleOrDefault(filter);  //Tek bir kayıt döndürmek için kullandığım method

        }

        public void AddOrUpdate(TContext context, TEntity entity)
        {
            TValidator validator = new TValidator();
            var validationResult = ValidatorTool.Validate(validator, entity);

            if (validationResult)
            {
                context.Set<TEntity>().AddOrUpdate(entity);

            }

        }

        public void Delete(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            context.Set<TEntity>().RemoveRange(context.Set<TEntity>().Where(filter));
        }

        public void Save(TContext context)
        {
            context.SaveChanges();
        }
    }
}
