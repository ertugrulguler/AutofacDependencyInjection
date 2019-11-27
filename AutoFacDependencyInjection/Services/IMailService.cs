using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacDependencyInjection.Services
{
    public interface IMailService
    {
        string CheckedMail(string mail);
    }
}
