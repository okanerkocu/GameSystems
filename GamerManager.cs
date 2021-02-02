using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerServices
    {
        IGamerCheckServices _gamerCheckServices;

        public GamerManager(IGamerCheckServices gamerCheckServices)
        {
            _gamerCheckServices = gamerCheckServices;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckServices.Verify(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " hesabını ekledik. Aramıza hoşgeldin");
            }
            else
            {
                Console.WriteLine("Kimlik doğrulamasında hata ile karşılaşıldı. Lütfen bilgilerini kontrol ediniz!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" bilgilerin güncellendi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " hesabınız silindi. Tekrar buluşmak dileğiyle");
        }
    }
}
