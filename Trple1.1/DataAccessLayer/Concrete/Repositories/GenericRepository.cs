using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class  //where'den sonrası koşul t'nın ne olacagı
    {
        Context c = new Context();                                 // ,burada yanlızca sınfı olmasını ısteseydık        where T : class,new()   
        DbSet<T> _object;                                           // sadece veritabanı nesnesı olmasını ısteseydık    where T : class,IEntity,new()   
                                                                   // veya bir değer tipi olmasını isteseydik           where T : class,struct
        public GenericRepository()
        {
            _object = c.Set<T>();
        }
        public void Delete(T p)
        {
            var DeletedEntity = c.Entry(p);                            //entitystate 41.video
            DeletedEntity.State = EntityState.Deleted;
            //_object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter) //37.video
        {
            return _object.SingleOrDefault(filter);          //tek olduğu için single or defalut kullandık.
        }

        public void Insert(T p)
        {
            var AddedEntity = c.Entry(p);                          //entitystate 41.video
            AddedEntity.State = EntityState.Added;
            //_object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var UpdatedEntity = c.Entry(p);                             //entitystate 41.video
            UpdatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
