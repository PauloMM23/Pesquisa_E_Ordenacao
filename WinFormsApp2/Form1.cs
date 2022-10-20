namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int index;
        Info info = new Info();
        Ordenacao ordenacao = new Ordenacao();
        Gerar popularLista = new Gerar();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = Int32.Parse(comboBox1.GetItemText(comboBox1.SelectedIndex));
            textBox2.Text = info.exibirInfo(index);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int quantidadeNumeros = Int32.Parse(textBox1.Text);
            List<int> listaNumeros = popularLista.popularLista(quantidadeNumeros);
            textBox3.Text = ordenacao.ordem(index, listaNumeros);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}