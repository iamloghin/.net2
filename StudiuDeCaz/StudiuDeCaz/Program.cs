using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudiuDeCaz.Models;

namespace StudiuDeCaz
{
    class Program
    {
        readonly ModelSelfRefrences modelSelfRefrences = new ModelSelfRefrences();
        
        modelSelfRefrences.SaveChanges();

        var allSelfReferences = modelSelfRefrences.Set<SelfReference>().ToList();
    }
}
