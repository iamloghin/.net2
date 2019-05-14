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
    
    public partial class Comanda
    {
        public Comanda()
        {
            this.Id = Guid.NewGuid();
        }

        public Comanda(Guid id)
        {
            this.Id = id;
        }
        public System.Guid Id { get; set; }
        public StareComanda StareComanda { get; set; }
        public System.DateTime DataSystem { get; set; }
        public System.DateTime DataProgramare { get; set; }
        public Nullable<System.DateTime> DataFinalizare { get; set; }
        public Nullable<int> KmBoard { get; set; }
        public string Descriere { get; set; }
        public Nullable<decimal> ValoarePiese { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Auto Auto { get; set; }
    }
}