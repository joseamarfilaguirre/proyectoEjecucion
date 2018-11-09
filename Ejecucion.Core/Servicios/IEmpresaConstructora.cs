using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejecucion.Core.Entidades;

namespace Ejecucion.Core.Servicios
{
    interface IEmpresaConstructora
    {
        //Empresa Constructora
        List<EmpresaConstructora> TraerEmpresasConstructoras(string buscar);
        EmpresaConstructora TraerEmpresaConstructora(int empresaId);
        void AgregarEmpresaConstructora(EmpresaConstructora empresa);
        void ActualizarEmpresaConstructora(EmpresaConstructora empresa);
        void QuitarEmpresaConstructora(int empresaId);

        ////Titulo
        //List<Titulo> TraerTitulos();

        ////TipoContacto
        //List<TipoContacto> TraerTiposContacto();

        ////Contacto
        //List<Contacto> TraerFormasDeContactoDePersona(int personaId);
        //void AgregarContacto(Contacto contacto);
        //void QuitarContacto(int contactoId);
    }
}