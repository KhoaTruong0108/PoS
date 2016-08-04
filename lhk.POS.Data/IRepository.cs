//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : IRepository.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System.Linq;
using lhk.POS.Core.Domain;

namespace lhk.POS.Data{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(object id);
        void Insert(T entity, bool isCommit = true);
        void Update(T entity, bool isCommit = true);
        void Delete(T entity, bool isCommit = true);
        IQueryable<S> GetSecondTable<S>() where S : BaseEntity;
        IQueryable<T> Table { get; }

        void Submit();
    }
}
