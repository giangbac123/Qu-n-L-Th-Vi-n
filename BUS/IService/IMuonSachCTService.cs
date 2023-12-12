using DAL.Model;
using DAL.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    internal interface IMuonSachCTService
    {
        bool Add(Phieumuonct ct, int sl, string masach);
        bool Update(int id, Phieumuonct ct, int sl, int s, string masach);
        bool Delete(int id, int sl, string masach);
        List<PhieuMuonCTJoin> GetAll();
        List<PhieuMuonCTJoin> GetById(string id);
    }
}
