using SistemaDeTarefas.Enums;

namespace SistemaDeTarefas.Models
{
    public class TarefaModel
    {
        public StatusTarefa Status { get; set; }
        public string? Descricao { get; set; }
        public string? Nome { get; set; }
        public int Id { get; set; }
    }
}
