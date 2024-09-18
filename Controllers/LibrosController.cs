using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros.Models
{
    using System.Collections.Generic;
    using Libros.Models;

    class LibrosController
    {
        private LibrosModel modeloLibros = new LibrosModel();

        public List<LibrosModel> todos()
        {
            return modeloLibros.todos();
        }

        public LibrosModel uno(LibrosModel Libro)
        {
            return modeloLibros.uno(Libro);
        }

        public string insertar(LibrosModel Libro)
        {
            return modeloLibros.insertar(Libro);
        }

        public string actualizar(LibrosModel Libro)
        {
            return modeloLibros.actualizar(Libro);
        }

        public string eliminar(LibrosModel Libro)
        {
            return modeloLibros.eliminar(Libro);
        }
    }
}
