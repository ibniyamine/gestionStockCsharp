using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMenu.Model1
{
    public class RapportLisetProduit
    {
        public string CodeProduit { get; set; }
        public string DesignationProduit { get; set; }
        public double PU { get; set; }
        public int QteMin { get; set; }
        public int QteCri { get; set; }
        public string Categorie { get; set; }
    }
}
