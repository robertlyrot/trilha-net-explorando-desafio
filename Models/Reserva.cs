namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            if (hospedes.Count <= this.Suite.Capacidade)
            {
                Console.WriteLine("O Cadastro foi concluido com sucesso!!");
                Hospedes = hospedes;
            }
            else
            {
                
                throw new ArgumentException("Limite de hospedes excediddo para o quarto selecionado");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
           
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
                
                decimal valor = DiasReservados * Suite.ValorDiaria;
                
            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 0.10M);
            }

            return valor;
        }
    }
}