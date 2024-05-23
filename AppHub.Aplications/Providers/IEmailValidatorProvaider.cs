using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHub.Aplications.Providers
{
    public interface IEmailValidatorProvaider : Iprovaider
    {

        public async Task<bool> IsEmailValid(string email);
    } 
}
