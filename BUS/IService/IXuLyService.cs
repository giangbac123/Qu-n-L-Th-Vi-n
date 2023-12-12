﻿using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    internal interface IXuLyService
    {
        bool Add(string id, Xulyvp xl);
        bool Update(string id, Xulyvp xl);
        bool Delete(string id);
        List<Xulyvp> GetAll();
        List<Xulyvp> GetById(string id);
    }
}
