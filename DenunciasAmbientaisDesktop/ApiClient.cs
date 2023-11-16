using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenunciasAmbientaisDesktop
{
    public class ApiClient
    {
        private readonly string _baseUrl;

        public ApiClient(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task<string> AdicionarDenuncia(string descricao, int tipo, string local, string foto)
        {
            using (HttpClient client = new HttpClient())
            {
                // Crie os parâmetros que você deseja enviar para a API
                var parametros = new MultipartFormDataContent();
                try
                {
                    
                    parametros.Add(new StringContent(descricao), "descricao");
                    parametros.Add(new StringContent(tipo.ToString()), "tipo");
                    parametros.Add(new StringContent(local), "local");
                    parametros.Add(new StringContent(foto), "foto");
                }
                catch (Exception e)
                {
                    // Se não for possível ler a resposta, exiba uma mensagem genérica de erro
                    return $"Alguns dos valores está vázio! Detalhes: {e.Message}";
                }
                

                // Construa o URL completo
                string urlCompleto = $"{_baseUrl}/api/Denuncias/adicionarDenunciaDesktop";

                // Faça a chamada HTTP para o endpoint da sua API
                var resposta = await client.PostAsync(urlCompleto, parametros);

                // Verifique se a chamada foi bem-sucedida
                if (resposta.IsSuccessStatusCode)
                {
                    // Leia a resposta da API
                    return await resposta.Content.ReadAsStringAsync();
                }
                else
                {
                    try
                    {
                        // Tente ler a resposta da API para obter detalhes do erro
                        string respostaErro = await resposta.Content.ReadAsStringAsync();
                        return $"Erro ao chamar a API. Detalhes: {respostaErro}";
                    }
                    catch (Exception ex)
                    {
                        // Se não for possível ler a resposta, exiba uma mensagem genérica de erro
                        return $"Erro ao chamar a API. Detalhes: {ex.Message}";
                    }
                }
            }
        }
    }
}
