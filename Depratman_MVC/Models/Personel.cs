//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Depratman_MVC.Models
{
    using System;
    using System.Collections.Generic;
    

    public partial class Personel
    {
        public int ID { get; set; }
        public Nullable<int> DepartmanID { get; set; }
        public string Ad { get; set; }
        public string Soyadi { get; set; }
        public Nullable<short> Maas { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string MedeniHali { get; set; }
    
        public virtual Departman Departman { get; set; }
    }
}
