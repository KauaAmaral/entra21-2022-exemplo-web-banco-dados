using Entra21.CSharp.ClinicaVeterinaria.Repositorio;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico
{
    // A classe RacaServico ira implementar a interface IRacaServico, ou seja, devera honrar as clausulas definidos na interface(contrato)
    public class RacaServico : IRacaServico
    {
        private RacaRepositorio racaRepositorio;

        public RacaServico(ClinicaVeterinariaContexto contexto)
        {
            racaRepositorio = new RacaRepositorio(contexto);
        }

        public void Cadastrar(string nome, string especie)
        {
            var raca = new Raca();
            raca.Nome = nome;
            raca.Especie = especie;

            racaRepositorio.Cadastrar(raca);

            Console.WriteLine($"Nome: {nome} Espécie: {especie}");
        }
    }
}
