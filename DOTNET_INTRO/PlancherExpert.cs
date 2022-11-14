using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_INTRO
{
    internal class PlancherExpert
    {
        private string name;
        private double materiaux;
        private double mainOeuvre;

        public PlancherExpert(string name="", double materiaux=0, double mainOeuvre=0)
        {
            this.name = name;
            this.materiaux = materiaux;
            this.mainOeuvre = mainOeuvre;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Materiaux
        {
            get { return materiaux; }
            set { materiaux = value; }
        }

        public double MainOeuvre
        {
            get { return mainOeuvre; }
            set { mainOeuvre = value; }
        }

        public string AfficherDetails()
        {
           return "* Vous avez choisis le type: "+this.Name+"\n";
        }
    }
}
