﻿using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPersonModelService
    {
        void AddModel(PersonModel model);
        void DeleteModel(PersonModel model);
        void UpdateModel(PersonModel model);
    }
}