using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansTs.vsts._Rapport
{
   public class Content : Rapport
    {
        public string rap = "content";

        public override string Getlayout()
        {
            return rap;
        }
    }
}
