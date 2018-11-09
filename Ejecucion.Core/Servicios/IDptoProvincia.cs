using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejecucion.Core.Entidades;

namespace Ejecucion.Core.Servicios
{
    interface IDptoProvincia
    {
        //Deprtamento Provincia
        List<DptoProvincia> TraerDptoProvincias(string buscar);
        DptoProvincia TraerDptoProvincia(int departamentoId);
        void AgregarDptoprovincia(DptoProvincia departamento);
        void ActualizarDptoprovincia(DptoProvincia departamento);
        void QuitarDptoprovincia(int departamentoId);
    }
}
