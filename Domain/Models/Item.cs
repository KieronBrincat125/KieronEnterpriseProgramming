using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    //Domain: Will be a project referenced by all the other layers and will 
    //        hold the data containers i.e Models

    //Note: Code first Approach

    //EFCore is the module that will be used to automatically shape/model the database

    class Item
    {
	    [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int categoryId { get; set;  }
        public double price { get; set; }
        public string description { get; set; }
        public string PhotoPath { get; set; }
    }
}
