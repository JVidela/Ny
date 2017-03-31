using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Entities.ViewModels
{
    public class IniciarSesionViewModel
    {
        public bool EsUsuarioRegistrado { get; set; }

        public HttpPostedFileBase ReporteDeMaterias { get; set; }

    }
}
