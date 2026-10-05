using SQLite;

namespace ProyectoFinalMAUI.Models;

public class ItemModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public string ImagenUrl { get; set; } = string.Empty;
}