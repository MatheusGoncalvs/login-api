namespace Login.Domain
{
    public class Pessoa
    {
        public int Id { get; private set; }
        public string UserId { get; set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
    }
}