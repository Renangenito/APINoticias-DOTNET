using APINoticias.Models.Models;

namespace APINoticias.Servico
{
    public class LoginServico
    {
        public async Task<LoginRespostaModel>Login(LoginRequisicaoModel loginRequisicaoModel)
        {
            LoginRespostaModel loginRespostaModel = new LoginRespostaModel();
            loginRespostaModel.Autenticado = false;
            loginRespostaModel.Usuario = loginRequisicaoModel.Usuario;
            loginRespostaModel.Token = "";
            loginRespostaModel.DataExpiracao = null;


            if(loginRequisicaoModel.Usuario == "UsuarioRenan" && loginRequisicaoModel.Senha == "SenhaRenan")
            {
                loginRespostaModel = new GeradorToken().GerarToken(loginRespostaModel);
            }
            return loginRespostaModel;
        }
    }
}
