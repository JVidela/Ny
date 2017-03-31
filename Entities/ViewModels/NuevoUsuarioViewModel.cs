using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Entities.ViewModels
{
    public class NuevoUsuarioViewModel
    {
        public HttpPostedFileBase ReporteDeMaterias { get; set; }

        public string NombreYApellido { get; set; }

        public string DireccionDeMail { get; set; }

        public string Contrasenia { get; set; }
    }
}
