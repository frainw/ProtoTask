using ProtoTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestaoTarefas
{
    
   public partial class FormSobre : Form
   {
        private static FormSobre _instance;
        private FormPrincipal _formPrincipal;
        private FormSobre(FormPrincipal formPrincipal)
        {
            _formPrincipal = formPrincipal;
            InitializeComponent();
        }

        public static FormSobre GetSobreInstance(FormPrincipal formPrincipal)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormSobre(formPrincipal);
            }
            return _instance;
        }
    }
}
