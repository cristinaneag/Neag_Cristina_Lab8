using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Neag_Cristina_Lab8.Models
{
    public class BookCategory
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        [Display(Name = "Book Title and Author")]
        public Book Book { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
