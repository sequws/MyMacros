using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        // Always per 100g
        public double Fats { get; set; }
        public double Carbs { get; set; }
        public double Proteins { get; set; }
        public double Cellulose { get; set; }
        // Additional information
        public string Infos { get; set; }

        // Weight of full recipe
        public double Weight { get; set; }
        public double PieceWeight { get; set; }

        public DateTime AddDate { get; set; }

        public double Kcal => 4 * (Carbs + Proteins) + 9 * Fats + 2 * Cellulose;
    }
}
