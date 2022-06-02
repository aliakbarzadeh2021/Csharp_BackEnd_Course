using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example5._7._1.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
