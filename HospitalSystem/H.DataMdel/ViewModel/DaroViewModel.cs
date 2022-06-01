using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataMdel.ViewModel
{
    public class DaroViewModel
    {
        [Required(ErrorMessage ="ridi")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "ridi")]
        public string? Description { get; set; }
    }
}
