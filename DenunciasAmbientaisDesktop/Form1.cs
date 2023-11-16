using System.Windows.Forms;

namespace DenunciasAmbientaisDesktop
{
    public partial class Form1 : Form
    {
        public String descricaoDenuncia;
        public int tipoDenuncia;
        public String localDenuncia;
        public string fotobase64;

        public Form1()
        {
            InitializeComponent();

            comboBoxTipo.Items.Add("Selecione um tipo");
            comboBoxTipo.Items.Add("Desmatamento");
            comboBoxTipo.Items.Add("Polui��o do ar");
            comboBoxTipo.Items.Add("Polui��o da �gua");
            comboBoxTipo.Items.Add("Ca�a ilegal");
            comboBoxTipo.Items.Add("Tr�fico de animais");
            comboBoxTipo.Items.Add("Descarte irregular");
            comboBoxTipo.Items.Add("Pesca predat�ria");
            comboBoxTipo.Items.Add("Queimadas ilegais");
            comboBoxTipo.Items.Add("Potencial enchentes");
            comboBoxTipo.Items.Add("Abuso de animais");
            comboBoxTipo.Items.Add("Outro (especifique na descri��o)");

            // Defina o primeiro item como selecionado
            comboBoxTipo.SelectedIndex = 0;
        }

        // Evento chamado quando o usu�rio seleciona um item no ComboBox
        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtenha o valor selecionado
            string tipoSelecionado = comboBoxTipo.SelectedItem.ToString();

            // Equipare o valor selecionado com os IDs
            int idSelecionado = 0; // Valor padr�o se n�o houver correspond�ncia

            if (tipoSelecionado == "Desmatamento")
                idSelecionado = 1;
            else if (tipoSelecionado == "Polui��o do ar")
                idSelecionado = 2;
            else if (tipoSelecionado == "Polui��o da �gua")
                idSelecionado = 3;
            else if (tipoSelecionado == "Ca�a ilegal")
                idSelecionado = 4;
            else if (tipoSelecionado == "Tr�fico de animais")
                idSelecionado = 5;
            else if (tipoSelecionado == "Descarte irregular")
                idSelecionado = 6;
            else if (tipoSelecionado == "Pesca predat�ria")
                idSelecionado = 7;
            else if (tipoSelecionado == "Queimadas ilegais")
                idSelecionado = 8;
            else if (tipoSelecionado == "Potencial enchentes")
                idSelecionado = 9;
            else if (tipoSelecionado == "Abuso de animais")
                idSelecionado = 10;
            else if (tipoSelecionado == "Outro (especifique na descri��o)")
                idSelecionado = 11;


            tipoDenuncia = idSelecionado;
            // Fa�a algo com o valor selecionado, se necess�rio
            //MessageBox.Show($"Tipo selecionado: {tipoSelecionado}, ID: {idSelecionado}");
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obt�m o caminho do arquivo selecionado
                    string caminhoDaImagem = openFileDialog.FileName;

                    // Converte a imagem para base64
                    string imagemBase64 = ConverterImagemParaBase64(caminhoDaImagem);

                    fotobase64 = imagemBase64;
                    // Fa�a algo com a imagem em base64, por exemplo, exibi-la ou enviar para a API
                    //MessageBox.Show($"Imagem em Base64:\n{imagemBase64}");
                    lblFotoEnviada.Text = "Foto anexada!";
                }


            }
        }

        private string ConverterImagemParaBase64(string caminhoDaImagem)
        {
            byte[] bytesDaImagem = File.ReadAllBytes(caminhoDaImagem);
            return Convert.ToBase64String(bytesDaImagem);
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            ApiClient apiClient = new ApiClient("http://localhost:5041");

            //byte[] imagemBytes = Convert.FromBase64String(fotobase64);

            string resultado = await apiClient.AdicionarDenuncia(txfDescricao.Text, tipoDenuncia, txfLocal.Text, fotobase64);

            if (resultado.Contains("Erro ao chamar a API"))
            {
                MessageBox.Show("Erro ao se conectar com a API! Verifique se todos os campos foram preenchidos e que uma foto foi enviada! Caso o erro persista tente novamente mais tarde! " + resultado);
            }
            else if (resultado.Contains("Alguns dos valores est� v�zio!"))
            {
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Den�ncia enviada com sucesso, e ser� encaminhada �s autoridades pertinentes o quanto antes! Obrigado!");
            }
            // Fa�a algo com o resultado, se necess�rio
            //MessageBox.Show($"Resultado da API: {resultado}");
        }
    }
}
