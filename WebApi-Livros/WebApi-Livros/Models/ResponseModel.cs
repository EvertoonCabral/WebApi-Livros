namespace WebApi_Livros.Models
{
    public class ResponseModel<T>
    {
        // T = tipoGenerico  ? = Pode ser nulo
        public T? Dados { get; set; }
        public String Message { get; set; } = String.Empty;
        public bool Status { get; set; } = true;


    }
}
