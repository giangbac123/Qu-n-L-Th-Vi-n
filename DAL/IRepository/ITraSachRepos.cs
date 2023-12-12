using DAL.Model;
using DAL.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface ITraSachRepos
    {
        bool AddTraSach(string id, Phieutra tra);
        bool DeleteTraSach(string matra);
        bool UpdateTraSach(string matra, Phieutra tra);
        List<PhieuTraJoin> GetAll();
        List<PhieuTraJoin> GetById(string matra);
    }
}

