﻿using BUS.IService;
using DAL.Model;
using DAL.Repository;
using DAL.view;

namespace BUS.Service
{
    public class SachService : ISachService
    {
        SachRepos _repos = new SachRepos();
        public SachService() { }

        public SachService(SachRepos repos)
        {
            _repos = repos;
        }

        public bool AddSach(string id, Sach sach)
        {
            return _repos.AddSach(id, sach);
        }

        public bool DeleteSach(string masach)
        {
            return _repos.DeleteSach(masach);
        }

        public List<SachJoin> GetAll()
        {
            return _repos.GetAll();
        }

        public List<SachJoin> GetById(string id)
        {
            return _repos.GetById(id);
        }

        public bool UpdateSach(string masach, Sach sach)
        {
            return _repos.UpdateSach(masach, sach);
        }
    }
}
