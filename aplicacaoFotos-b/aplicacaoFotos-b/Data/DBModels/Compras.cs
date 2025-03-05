namespace aplicacaoFotos_b.Data.DBModels;

public class Compras
{
    public int Id { get; set; }
    
    public DateTime Data { get; set; }
    
    public EstadosCompras Estados { get; set; }
    
    public enum EstadosCompras
    {
        iniciada,
        paga,
        enviado,
        concluido
    }
}