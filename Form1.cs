namespace Aula10Estacionamento
{
    public partial class Form1 : Form
    {

        List<string> estacionamento = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        void removeCarro ()
        {
            estacionamento.RemoveAt(0);
            atualizaInterface();
        }

        void adcionaCarro ()
        {

            string vaga = txtPlaca.Text;
            estacionamento.Add(vaga);

            if ( vaga == "")
            {
                MessageBox.Show(" Preencha todos os campos! ");
            }
        }
        void atualizaInterface()
        {
            
            int vagasCadastrada = estacionamento.Count();
            lblPlacas.Text = vagasCadastrada.ToString();

            int vaga = 0;
            for (int i = 0; i < estacionamento.Count; i++)
            {
                int quantidade = int.Parse(estacionamento[i]);
               vaga += quantidade;
            }
            



        }

        private void btnEstacionar_Click(object sender, EventArgs e)
        {
            if ( estacionamento.Count>=5 )
            {
                MessageBox.Show("Todas as vagas estão preenchidas!");
                return;
            }

            if (txtPlaca.Text == " ")
            {
                MessageBox.Show("Preencha os campos para continuar");
            }

            adcionaCarro();
            atualizaInterface();
            string placa = txtPlaca.Text;
            listView1.Items.Clear();

            for (int  i = 0;i < estacionamento.Count;i++)
            {
                listView1.Items.Add($"[VAGA - {i}]  estacionamento[i]");
            }

          

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            removeCarro();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizaInterface();
            
        }
    }
}