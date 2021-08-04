using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.ViewModles
{
    
    public class AddEventCategoryViewModel
    {

        [Required(ErrorMessage ="This field is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="Must be between 3 and 20 characters.")]
        public string Name { get; set; }


}
}
