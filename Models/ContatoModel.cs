namespace ControleDeCadastros.Models
{
    public class ContatoModel
    {
        public int Id { get; set; } // Representa um código numerado dos registros de contato
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Numero { get; set; }
    }
}
