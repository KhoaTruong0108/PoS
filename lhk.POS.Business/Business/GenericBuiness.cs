//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : GenericBuiness.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System;
using System.Linq;
using System.Collections.Generic;
using lhk.POS.Core.Domain;
using lhk.POS.Core.Util;
using lhk.POS.Data;
using lhk.POS.Core;

namespace lhk.POS.Common.Business{
	public class GenericBuiness<T> : IDisposable, IBusiness<T> where T : BaseEntity, new() {
        protected IRepository<T> _repository;

        public string Insert(T entity, bool isCommit = true)
        {
            string result = string.Empty;
            try
            {
                _repository.Insert(entity, isCommit);
            }
            catch (Exception ex)
            {
                AppLogger.logError(ex);
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        public string Update(T entity, bool isCommit = true)
        {
            string result = string.Empty;
            try
            {
                T item = _repository.GetById(entity.Id);

                foreach(var property in typeof(T).GetProperties())
                {
                    property.SetValue(item,property.GetValue(entity, null));
                }

                _repository.Update(item, isCommit);
            }
            catch (Exception ex)
            {
                AppLogger.logError(ex);
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        public string Delete(int id, bool isCommit = true)
        {
            string result = string.Empty;
            try
            {
                T entity = _repository.Table.FirstOrDefault(e => e.Id.Equals(id));
                _repository.Delete(entity, isCommit);
            }
            catch (Exception ex)
            {
                AppLogger.logError(ex);
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        public T GetById(int id)
        {
            T entity = null;
            try
            {
                entity = _repository.Table.FirstOrDefault(e => e.Id.Equals(id));
                if (entity == null)
                {
                    AppLogger.logInfo(string.Format("Entity of {0} not found.", typeof(T)));
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(ex);
            }
            return entity;
        }

        public IEnumerable<T> GetAll()
        {
            IEnumerable<T> entities = null;
            try
            {
                entities = _repository.Table;
                AppLogger.logInfo(this.ToString(), string.Format("Getting all entities of {0} - Found: {1}.", typeof(T), entities.Count()));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                //throw;
            }
            return entities;
        }

        public void Dispose()
        {
            
        }

    }
}
