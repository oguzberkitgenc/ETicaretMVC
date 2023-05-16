﻿using DataAccessLayer.Context;
using EntityLayer.Tables;
using System.Collections.Generic;

namespace ETicaretMVC.Models
{
    public class IndexViewModel
    {

        public List<HomePage> homePages { get; set; }
        public List<SocialMedia> socialMedias { get; set; }
        public List<Product> products { get; set; }
    }
}
