using backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Data
{
    public interface IKullanıcıRepository
    {
        IEnumerable<KullanıcıBilgi> GetAll();
        String KullanıcıEkle(KullanıcıBilgi Kullanıcı);
        String KullanıcıDöndür(KullanıcıBilgi kullanıcı);
    }
}
