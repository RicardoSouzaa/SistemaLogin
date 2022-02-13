namespace SistemaLogin
{
    internal static class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario(){Nome = "Ricardo", Senha="123"},
            new Usuario(){Nome = "Ana", Senha = "321"}
        };

        private static Usuario _Logado = null; // usuario que está logado no momento

        public static Usuario UsuarioLogado // propriedade que manipula o _Logado
        {
            get { return _Logado; }
            private set { _Logado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha) // compara se nome e senha digitado é a mesma do banco.
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}