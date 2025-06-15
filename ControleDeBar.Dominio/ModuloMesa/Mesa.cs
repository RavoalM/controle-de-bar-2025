using ControleDeBar.Dominio.Compartilhado;

namespace ControleDeBar.Dominio.ModuloMesa;

public class Mesa : EntidadeBase<Mesa>
{
    public int Numero { get; set; }
    public int Capacidade { get; set; }
    public bool EstaOcupado { get; set; }

    public Mesa() { }

    public Mesa(int numero, int quantidadeDeAssentos) : this()
    {
        Id = Guid.NewGuid();
        Numero = numero;
        Capacidade = quantidadeDeAssentos;
        EstaOcupado = false;
    }

    public void Ocupar()
    {
        EstaOcupado = true;
    }

    public void Desocupar()
    {
        EstaOcupado = false;
    }

    public override void AtualizarRegistro(Mesa registroEditado)
    {
        Numero = registroEditado.Numero;
        Capacidade = registroEditado.Capacidade;
    }
}
