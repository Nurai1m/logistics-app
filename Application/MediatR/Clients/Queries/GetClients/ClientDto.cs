using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MediatR.Clients.Queries
{
    public class ClientDto
    {
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Amount { get; set; } = 0;
    }
}
