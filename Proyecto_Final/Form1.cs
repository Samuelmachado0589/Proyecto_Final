namespace Proyecto_Final
{
    public partial class FormularioPdre : Form
    {
        public FormularioPdre()
        {
            InitializeComponent();
        }

        private void nuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmRegistros = null;
            switch (e.ClickedItem.Text)
            {
                case "Item1":
                    FrmRegistros = new FormularioPdre();
                    break;
                case "Item2":
                    FrmRegistros = new FrmRegistros();
                    break;
                    //...
            }

            if (FrmRegistros != null)
            {
                AbrirFormEnPanel(formularioHijo);
            }
        }
    }
}
