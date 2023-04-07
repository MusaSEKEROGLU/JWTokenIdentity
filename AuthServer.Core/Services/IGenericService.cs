using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IGenericService<TEntity,TDto> 
        where TEntity : class
        where TDto : class
    {
        Task<Response<TDto>> GetByIdAsync(int id);
        Task<Response<IEnumerable<TDto>>> GetAllAsync();
        Task<Response<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> predicate);
        Task<Response<TDto>> AddAsync(TDto dto);
        Task<Response<NoDataDto>> Update(TDto dto, int id); //Async methodu yok
        Task<Response<NoDataDto>> Remove(int id); //Async methodu yok
    }
}
//Update ve Remove methodlarında geriye birşey dönmeyeceğimiz için
//SharedLayer içinde boş bir sınıf oluşturup bunu döndük