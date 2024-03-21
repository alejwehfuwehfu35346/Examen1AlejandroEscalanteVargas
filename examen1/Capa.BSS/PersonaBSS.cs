using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.DAL;
using Capa.Modelos;

namespace Capa.BSS
{
    PersonaDal dal = new PersonaDal();
    public DataTable ListarPersonaBss()
    {
        return dal.ListarPersonasDal();
    }
}
