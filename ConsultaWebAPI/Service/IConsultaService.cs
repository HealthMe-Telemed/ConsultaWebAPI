using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaWebAPI.Service
{
    public interface IConsultaService
    {
        public Task<bool> CriarConsulta(string linkConsulta);
    }
}