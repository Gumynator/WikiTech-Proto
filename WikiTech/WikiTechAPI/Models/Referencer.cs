﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WikiTechAPI.Models
{
    public partial class Referencer
    {
        public int IdTag { get; set; }
        public int IdArticle { get; set; }

        public virtual Article IdArticleNavigation { get; set; }
        public virtual Tag IdTagNavigation { get; set; }
    }
}
