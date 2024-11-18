using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalhealthApp
{
    public interface IUsuarioApiService
    {
        Task<bool> EnviarCodigoVerificacion(string telefono);
        Task<string> VerificarCodigo(string codigo);
    }
}
