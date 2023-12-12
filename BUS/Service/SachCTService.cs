using BUS.IService;
using DAL.Model;
using DAL.Repository;
using DAL.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class SachCTService : ISachCTService
    {
        SachCTRepos _repos = new SachCTRepos();
        public SachCTService() { }

        public SachCTService(SachCTRepos repos)
        {
            _repos = repos;
        }

        public bool AddSach(Sachchitiet sach)
        {
            return _repos.AddSach(sach);
        }

        public bool DeleteSach(int id)
        {
            return _repos.DeleteSach(id);
        }
        public List<SachCTJoin> GetAll()
        {
            return _repos.GetAll();
        }

        public List<SachCTJoin> GetById(string id)
        {
            return _repos.GetById(id);
        }

        public bool UpdateSach(int masach, Sachchitiet sach)
        {
            return _repos.UpdateSach(masach, sach);
        }
    }
}
