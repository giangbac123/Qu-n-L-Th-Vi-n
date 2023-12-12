using DAL.Model;
using DAL.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    internal interface IMuonSachService
    {
        bool AddMuonSach(string id, Phieumuon muon);
        bool DeleteMuonSach(string mamuon, string masach, int sl);
        bool UpdateMuonSach(string id, Phieumuon muon);
        List<PhieuMuonJoin> GetAll();
        List<PhieuMuonJoin> GetById(string id);
    }
}
