using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxpayerProject.Models
{
     public class Taxpayers
    {
        private string _email;
        private int _amount;

        public Taxpayers(string name, string email, int amount)
        {
            if (String.IsNullOrEmpty(email))
                throw new ArgumentNullException(nameof(email));
            
            
            Name = name;
            Email = email;
            Amount = amount;
        }

        public string Name { get; set; }
        public string Email { get => _email; set => _email = value; }
        public int Amount { get => _amount; set => _amount = value; }

        public override string ToString()
        {
            return $"{Name} ({Email}| Adó: {Amount}Ft)";
        }

        public void Increase(int value)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _amount += value;


        }

        public void Decrease(int value)
        {
            if (value >= 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _amount += value;


        }


    }
}
