using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Entity
{
    public class KullanıcıBilgi
    {
        [Key]
        public int ID { get; set; }
        public String İsim { get; set; }
        public String Soyisim { get; set; }
        public String Mail { get; set; }
        public String Parola { get; set; }
    }
}
