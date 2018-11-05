﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorldWideImporters.Models.ViewModels
{
    public class Info
    {

        public Info() { }
        public Info(string Name, string PName, string Phone, string Fax, string Email, DateTime Member)
        {
            this.Name = Name;
            this.PName = PName;
            this.Phone = Phone;
            this.Fax = Fax;
            this.Email = Email;
            this.Member = Member;
        }

        //Part 1 of Assignment
        //Person Information
        [Key]
        public string Name { get; set; }

        [Display(Name="Preferred Name")]
        public string PName { get; set; }
        [Display(Name="Phone Number")]
        public string Phone { get; set; }
        [Display(Name="Fax Number")]
        public string Fax { get; set; }
        [Display(Name="Email Address")]
        public string Email { get; set; }
        [Display(Name="Member Since")]
        public DateTime Member { get; set; }
        
        //Part 2 of Assignment
        //Company Information
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyFax { get; set; }
        public string Website { get; set; }
        public DateTime? CompanyYear { get; set; }

        //Purchases Information
        public int? Orders { get; set; }
        public decimal? GrossSales { get; set; }
        public decimal? GrossProfit { get; set; }

        //Top Products Information
        public IEnumerable<Product> Products { get; set; }        
    }
}