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
        //Verifica se a capacidade é maior ou igual ao número de hóspedes sendo recebido
        //IMPLEMENTADO!!!
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
        //Retorna uma exception caso a capacidade seja menor que o número de hóspedes recebido
                Console.WriteLine("Quantidade de hóspedes é maior que a capacidade.");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
        //Retorna a quantidade de hóspedes (propriedade Hospedes)
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }
        public decimal CalcularValorDiaria()
        {
        //Retorna o valor da diária
            decimal valor = DiasReservados * (Suite.ValorDiaria);
        // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                return valor = (valor - valor / 10);
            }
            return valor;
        }
    }
}