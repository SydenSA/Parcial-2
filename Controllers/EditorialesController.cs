using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editoriales.Models
{
    using System.Collections.Generic;
    using Editoriales.Models;

    class EditorialesController
    {
        private EditorialesModel modeloEditoriales = new EditorialesModel();

        public List<EditorialesModel> todos()
        {
            return modeloEditoriales.todos();
        }

        public EditorialesModel uno(EditorialesModel Editorial)
        {
            return modeloEditoriales.uno(Editorial);
        }

        public string insertar(EditorialesModel Editorial)
        {
            return modeloEditoriales.insertar(Editorial);
        }

        public string actualizar(EditorialesModel Editorial)
        {
            return modeloEditoriales.actualizar(Editorial);
        }

        public string eliminar(EditorialesModel Editorial)
        {
            return modeloEditoriales.eliminar(Editorial);
        }
    }
}
