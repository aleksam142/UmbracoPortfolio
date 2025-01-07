﻿using AleksaPortfolio.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace AleksaPortfolio.Models.Interfaces
{
    public interface IProjectCardFactory
    {
        public ProjectCardViewModel Create(IPublishedElement element);
    }
}