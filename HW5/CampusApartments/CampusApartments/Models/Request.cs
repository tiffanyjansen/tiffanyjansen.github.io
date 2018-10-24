﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CampusApartments.Models
{
    public class Request
    {
        [Required]
        [StringLength(25)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Apartment Name")]
        public string ApartmentName { get; set; }

        [Required]
        [Display(Name = "Unit Number")]
        public int UnitNumber { get; set; }

        [Required]
        [StringLength(1000)]
        public string MaintenanceRequired { get; set; }

        public DateTime TimeOfRequest
        {
            get
            {
                var today = DateTime.Today;
                return today;
            }
        }

        public int Permission
        {
            get
            {
                int permission = 0;
                return permission;
            }
        }
    }
}