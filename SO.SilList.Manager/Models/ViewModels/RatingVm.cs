﻿using SO.SilList.Manager.Models.ValueObjects;
using SO.SilList.Utility.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.SilList.Manager.Models.ViewModels
{
    public class RatingVm
    {
        public List<RatingVo> result { get; set; }
        public string keyword { get; set; }

         [DisplayName("isActive: ")]
         public bool? isActive { get; set; }
         public string submitButton { get; set; }
         public Paging paging;

         public RatingVm()
        {
            this.result = new List<RatingVo>();
            if (paging == null)
                paging = new Paging();
        }
    }
}
