using BUS.IService;
using DAL.Model;
using DAL.Repository;
using DAL.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS.Service
{

    public class TraSachService : ITraSachService
    {
        TraSachRepos _repos = new TraSachRepos();
        public TraSachService() { }
        public TraSachService(TraSachRepos repos)
        {
            _repos = repos;
        }
        public List<Phieumuon> GetMuon()
        {
            return _repos.GetMuon();
        }
        public bool AddTraSach(string id, Phieutra tra)
        {
            return _repos.AddTraSach(id,tra);
        }

        public bool DeleteTraSach(string matra)
        {
            return _repos.DeleteTraSach(matra);
        }

        public List<PhieuTraJoin> GetAll()
        {
            return _repos.GetAll();
        }
        public List<PhieuTraJoin> GetById(string matra)
        {
            return _repos.GetById(matra);
        }

        public bool UpdateTraSach(string matra, Phieutra tra)
        {
            return _repos.UpdateTraSach(matra, tra);
        }
    }
}

