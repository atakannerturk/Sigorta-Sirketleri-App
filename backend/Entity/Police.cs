using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Entity
{
    public class Police
    {
        [Key]
        public int ID { get; set; }
        public KullanıcıBilgi Kullanıcı { get; set; }
        public string policeturu { get; set; }

        public DateTime olusturmaTarihi { get; set; }

        public bool isActive { get; set; }
        public DateTime silinmeTarihi { get; set; }

    }
}
