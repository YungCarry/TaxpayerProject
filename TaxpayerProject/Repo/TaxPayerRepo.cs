using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxpayerProject.DBModels;
using TaxpayerProject.Models;

namespace TaxpayerProject.Repo
{
    public class TaxPayerRepo
    {
        private readonly TaxpayerContext context = new();

        public List<Taxpayers> GetAll()
        {
            return context.taxpayer.ToList();
        }

        public List<Taxpayers> GetMinimum(int min)
        {
            return context.taxpayer.Where(e => e.Amount > min).ToList();
        }

        public List<Taxpayers> GetAllByDesc()
        {
            return context.taxpayer.OrderByDescending(e => e.Amount).ToList();
        }

        public List<Taxpayers> GetByEmailDomain(string domain)
        {
            return context.taxpayer.Where(e => e.Email.EndsWith(domain)).ToList();
        }

        public int GetCount()
        {
            return context.taxpayer.Count();
        }

        
    }
}
