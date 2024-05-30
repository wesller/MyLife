namespace MyLife
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            AnotacoesFrm f = new AnotacoesFrm();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnotacoesFrm anotacoes = new AnotacoesFrm();
            anotacoes.Show();
        }
    }
}
