using System.ComponentModel.DataAnnotations.Schema;

namespace aplicacaoFotos_b.Data.DBModels;

public class Fotografias
{
    public int Id { get; set; }
    
    public string Titulo { get; set; }
    
    public string Descricao { get; set; }
    
    public string Ficheiro { get; set; }
    
    public DateTime DataFotografia { get; set; }
    
    public decimal Preço { get; set; }
    
    
    
    //FK Utilizador
    [ForeignKey(nameof(Utilizador))]
    public int UtilizadorFk { get; set; }
    
    public Utilizadores Utilizador { get; set; }
    
    [ForeignKey(nameof(Dono))]
    public int DonoFk { get; set; }
    
    public Utilizadores Dono { get; set; }
    
    [ForeignKey(nameof(Categoria))]
    public int CategoriaFk{ get; set; }
    
    public Categorias Categoria { get; set; }
    
    //many->many Gostos
    public ICollection<Gostos> ListaGostos { get; set; }
    //many->many Compras
    public ICollection<Compras> ListaCompras { get; set; }

    
}

