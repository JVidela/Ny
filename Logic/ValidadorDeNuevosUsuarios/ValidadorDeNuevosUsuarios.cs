using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;

namespace Logic.ValidadorDeNuevosUsuarios
{
    public class ValidadorDeNuevosUsuarios
    {

        private ConfiguracionPorUniversidad Configuracion;

        public void ParsearDatosDelNuevoUsuario()
        {
            var textoDelPdf = ParsearPdfATexto();
            ConfigurarUniversidad(textoDelPdf);
            ParsearDatosPersonales(textoDelPdf);
            ParsearDatosDeMaterias(textoDelPdf);
        }

        private string ParsearPdfATexto()
        {
            return "";
        }

        private void ConfigurarUniversidad(string textoDelPdf)
        {
            var listaBaseDeDatos = new List<Carrera>();
            this.Configuracion = null;
        }

        private void ParsearDatosPersonales(string textoDelPdf) { }

        private void ParsearDatosDeMaterias(string textoDelPdf) { }

        private bool DatosDeMateriasCorrectos()
        {
            return false;
        }

        private bool DatosPersonalesCorrectos()
        {
            return true;
        }
    }
}
