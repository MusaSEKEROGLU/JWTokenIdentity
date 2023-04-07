using System;
using System.Collections.Generic;

namespace SharedLibrary.Dtos
{
    public class ErrorDto
    {
        public List<String> Errors { get; private set; }
        public bool IsShow { get; private set; } //Kullanıcıya hata gösterilecekmi?

        public ErrorDto(List<string> errors)
        {
            Errors = new List<string>();
        }

        //tek bir hata
        public ErrorDto(string error, bool isShow)
        {
            Errors.Add(error);
            IsShow = true;
        }

        //birden fazla hata
        public ErrorDto(List<string>error, bool isShow)
        {
            Errors = Errors;
            IsShow = isShow;
        }
    }
}
