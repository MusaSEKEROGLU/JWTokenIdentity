namespace AuthServer.Core.Dtos
{
    //Yeni Kullanıcı Oluşturmak
    public class CreateUserDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
