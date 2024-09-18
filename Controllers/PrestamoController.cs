using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.Models
{
    using Prestamos.Models;

    class PrestamosController
    {
        private PrestamosModel modeloPrestamos = new PrestamosModel();


        public List<PrestamosModel> todos()
        {
            return modeloPrestamos.todos();
        }


        public PrestamosModel uno(PrestamosModel Prestamo)
        {
            return modeloPrestamos.uno(Prestamo);
        }

        public string insertar(PrestamosModel Prestamo)
        {
            return modeloPrestamos.insertar(Prestamo);
        }


        public string actualizar(PrestamosModel Prestamo)
        {
            return modeloPrestamos.actualizar(Prestamo);
        }

        public string eliminar(PrestamosModel Prestamo)
        {
            return modeloPrestamos.eliminar(Prestamo);
        }
    }
}
