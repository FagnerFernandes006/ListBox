namespace ExercicioSenac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(texto.Text);
            texto.Text = String.Empty;
            Quantidade.Text = listBox.Items.Count.ToString(); 
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            var position = listBox.SelectedIndex;
            if (position != -1)
            {
                listBox.Items.RemoveAt(position);
                Quantidade.Text = listBox.Items.Count.ToString();
                Posicao.Text = string.Empty;
                textoItem.Text = string.Empty;
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var position = listBox.SelectedIndex;
            if (position != -1)
            {
                var itemNome = listBox.Items[position];
                Posicao.Text = position.ToString();
                textoItem.Text = itemNome.ToString();
            }
        }

        private void LimparAll_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            Posicao.Text = string.Empty;
            textoItem.Text = string.Empty;
            Quantidade.Text= string.Empty;
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}