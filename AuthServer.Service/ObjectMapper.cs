using AutoMapper;
using System;

namespace AuthServer.Service
{
    public static class ObjectMapper
    {
        //datayı alana kadar memory de bulunmasın lazyLoading
        //ihtiyaç olduğunda yüklesin ve isteğimizde memory den biz çekelim
        private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DtoMapper>();
            });
            return config.CreateMapper();
        });
        //isteğimizde memory den biz çekelim
        public static IMapper Mapper => lazy.Value;       
    }
}
