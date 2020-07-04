﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupport.ViewModels
{
    public class CreateViewModel
    { 
        [Required]
        public string Message { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
