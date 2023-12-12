using DAL.Model;
using DAL.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    internal interface ISachCTService
    {
        bool AddSach(Sachchitiet sach);
        bool DeleteSach(int id);
        bool UpdateSach(int masach, Sachchitiet sach);
        List<SachCTJoin> GetAll();
        List<SachCTJoin> GetById(string id);
    }
}
