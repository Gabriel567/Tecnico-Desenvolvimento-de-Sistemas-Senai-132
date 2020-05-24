using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class AbstractController : Controller
    {
        protected const string SESSION_CLIENTE_EMAIL = "cliente_email";
        protected const string SESSION_CLIENTE_NOME = "cliente_nome";
        protected const string SESSION_TIPO_USUARIO = "cliente.tipoUsuario";

        protected string ObterUsuarioSession()
        {

            var email = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);

            if(!string.IsNullOrEmpty(email))
            {
                return email;
            }
            else
            {
                return "";
            }
        }

        protected string ObterUsuarioNomeSession()
        {

            var nome = HttpContext.Session.GetString(SESSION_CLIENTE_NOME);

            if(!string.IsNullOrEmpty(nome)){
                return nome;
            }else{

                return "" ;

            }
        }

        protected string ObterTipoUsuarioNomeSession(){

            var TipoUsuario = HttpContext.Session.GetString(SESSION_TIPO_USUARIO);

            if(!string.IsNullOrEmpty(TipoUsuario))
            {
                return TipoUsuario;
            }
            else
            {
                return "" ;
            }
        }
    }
}