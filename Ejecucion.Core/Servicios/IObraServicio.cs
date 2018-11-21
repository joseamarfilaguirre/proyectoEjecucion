using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejecucion.Core.Entidades;

namespace Ejecucion.Core.Servicios
{
    interface IObraServicio
    {
        //Obra
        List<ObraBrowse> TraerObra(int obrdaId);
        Obras traerObra(int obraId);
        void agregarObra(Obras obra);
        void actualizarObra(Obras obra);
        void eliminarObra(int obraId);

        //Dpto Provincia
        List<DptoProvincia> TraerDptos(string Buscar);

        //Programa de la Obra
        List<Programa> TraerObras(string Buscar);

        //Empresa Constructora
        List<EmpresaConstructora> TraerEmpresaConstructora(string Buscar);
    }
}
