//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Operatie
    {
        public Operatie()
        {
            this.Id = Guid.NewGuid();
        }

        public Operatie(Guid id)
        {
            this.Id = id;
        }

        public System.Guid Id { get; set; }
        public string Denumire { get; set; }
        public Nullable<decimal> TimpExecutie { get; set; }
    }
}
