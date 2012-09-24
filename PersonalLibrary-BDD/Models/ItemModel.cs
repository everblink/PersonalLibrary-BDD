using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalLibrary_BDD.Models
{
    public class ItemModel
    {
        [Required]
        [Display(Name = "Item Name")]
        public string ItemName { get; set; }

        [Required]
        [Display(Name = "Item Format")]
        public string ItemFormat { get; set; }

        [Required]
        [Display(Name = "Item Type")]
        public string ItemType { get; set; }

    }
}