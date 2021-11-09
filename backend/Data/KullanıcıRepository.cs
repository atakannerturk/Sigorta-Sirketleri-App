using backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Data
{
    public class KullanıcıRepository : IKullanıcıRepository
    {
        private ApiDbContext context;
        public KullanıcıRepository (ApiDbContext _context)
        {
            context = _context;
        }

        public IEnumerable<KullanıcıBilgi> GetAll()
        {
            return context.KullanıcıBilgis;
        }

        public String KullanıcıDöndür(KullanıcıBilgi kullanıcı)
        {
            var Mail = context.KullanıcıBilgis.FirstOrDefault(p => p.Mail == kullanıcı.Mail);
            if (Mail == null)
            {
                return "Kullanıcı Bulunamadı";
            }
            else
            {
                if(MD5Encrypt.MD5Hash(kullanıcı.Parola) == Mail.Parola)
                {
                    return "Giriş Başarılı";

                }
                else
                {
                    return "Hatalı Parola";
                }
            }
            
        }

        public String KullanıcıEkle(KullanıcıBilgi kullanıcı)
        {

            var kontrol = context.KullanıcıBilgis.FirstOrDefault(p => p.Mail == kullanıcı.Mail);
            if (kontrol == null)
            {
                String md5sifre;
                md5sifre = MD5Encrypt.MD5Hash(kullanıcı.Parola);
                kullanıcı.Parola = md5sifre;

                context.KullanıcıBilgis.Add(kullanıcı);
                context.SaveChanges();
                return "Kullanıcı Oluşturuldu";
            }
            else
            {
                return "Mail Kullanılıyor.Lütfen Başka Bir Mail Adresi Giriniz...";

            }
            
        }  
    }
}
