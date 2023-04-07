using System;
using System.Collections.Generic;

namespace AuthServer.Core.Configuration
{
    //AuthServer'a istek yapacak olan frontend tarafı
    public class Client
    {
        public string Id { get; set; } 
        public string Secret { get; set; }

        //hangi Api'lere ulaşacığını belirteceğimiz property-Audiences
        //Payload da gözükecek
        public List<String> Audiences { get; set; }
    }
}
