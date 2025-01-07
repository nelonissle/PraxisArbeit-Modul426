using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFWordListApp.Models
{
    public class Settings
    {
        public int Id { get; set; }
        public string Language { get; set; } // "Deutsch" or "Französisch"
        public bool CaseSensitive { get; set; }
    }
}

