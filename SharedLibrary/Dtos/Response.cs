using System.Text.Json.Serialization;

namespace SharedLibrary.Dtos
{
    public class Response<T> where T : class
    {
        public T Data { get; private set; }
        public int StatusCode { get; private set; }
        public ErrorDto Error { get; private set; }

        [JsonIgnore] //kullanıcı görmesin
        public bool IsSuccessFull { get; private set; }

        //Başarılı veri dönen
        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T> { Data = data, StatusCode = statusCode, IsSuccessFull = true };
        }
        //Başarılı veri dönmeyen/silmek,güncellemek gibi
        public static Response<T> Success(int statusCode)
        {
            return new Response<T> {Data = default, StatusCode = statusCode, IsSuccessFull = true };
        }
        //Başarısız veri yok
        public static Response<T> Fail(ErrorDto errorDto, int statusCode,bool isShow)
        {
            return new Response<T> { Error = errorDto, StatusCode = statusCode, IsSuccessFull = false };
        }
        //Başarısız veri yok tek bir mesaj için
        public static Response<T> Fail(string errorMessage, int statusCode, bool isShow)
        {
            var errorDro = new ErrorDto(errorMessage, isShow);
            return new Response<T> { Error = errorDro, StatusCode = statusCode, IsSuccessFull = false };
        }
    }
}
