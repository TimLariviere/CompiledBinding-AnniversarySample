using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiledBinding_AnniversaryEdition_Sample
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string GetFullname()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}
