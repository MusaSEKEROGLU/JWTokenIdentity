namespace AuthServer.Core.Dtos
{
    //Client'ların göreceği property'ler
    //IdentityUser içindeki property'lerden görünecek olanları yazıyoruz
    public class UserAppDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
}
