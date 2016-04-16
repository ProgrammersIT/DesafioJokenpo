using System;
using System.Linq;

namespace OficinaPI.Referencia.Jokenpo.Testes
{
	public class JuizJokenpo
	{
		public Resultado Avaliar(Jogada jogada1, Jogada jogada2)
		{
			if (jogada1 == jogada2)
				return Resultado.Empate;

			return CalcularJogadaVencedora (jogada1, jogada2);
		}

		private static Resultado CalcularJogadaVencedora (params Jogada[] jogadas)
		{
			if (PedraGanha (jogadas))
				return Resultado.Pedra;
			if (TesouraGanha (jogadas))
				return Resultado.Tesoura;

			return Resultado.Papel;
		}

		private static bool PedraGanha (params Jogada[] jogadas)
		{
			return jogadas.Any (j => j == Jogada.Pedra) && jogadas.Any (j => j == Jogada.Tesoura);
		}

		private static bool TesouraGanha (params Jogada[] jogadas)
		{
			return jogadas.Any (j => j == Jogada.Papel) && jogadas.Any (j => j == Jogada.Tesoura);
		}
	}
}

