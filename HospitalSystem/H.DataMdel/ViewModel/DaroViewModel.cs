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
        [Required(ErrorMessage ="error title")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "error description")]
        public string? Description { get; set; }
    }
}
