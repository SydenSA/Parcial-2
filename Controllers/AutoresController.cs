using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Autores.Models
{
    using System.Collections.Generic;
    using Autores.Models;

    class AutoresController
    {

        private AutoresModel modeloAutores = new AutoresModel();

        public List<AutoresModel> todos()
        {
            return modeloAutores.todos();
        }
        public AutoresModel uno(AutoresModel Autor)
        {
            return modeloAutores.uno(Autor);
        }
        public string insertar(AutoresModel Autor)
        {
            return modeloAutores.insertar(Autor);
        }
        public string actualziar(AutoresModel Autor)
        {
            return modeloAutores.actualizar(Autor);
        }
        public string eliminar(AutoresModel Autor)
        {
            return modeloAutores.eliminar(Autor);
        }
    }
}
