using NUnit.Framework;

namespace OficinaPI.Referencia.Jokenpo.Testes
{
	public class JuizJokenpoTestes
	{
		JuizJokenpo juiz;

		[SetUp]
		public void SetUp()
		{
			juiz = new JuizJokenpo ();
		}

		[Test]
		public void TestaSeRetornaEmpateAoAvaliarJogadasIguais()
		{
			var avaliacao = juiz.Avaliar (Jogada.Pedra, Jogada.Pedra);

			Assert.AreEqual (Resultado.Empate, avaliacao);
		}

		[TestCase(Jogada.Pedra, Jogada.Tesoura)]
		[TestCase(Jogada.Tesoura, Jogada.Pedra)]
		public void TestaSeRetornaPedraAoCompararPedra_E_Tesoura(Jogada jogada1, Jogada jogada2)
		{
			var avaliacao = juiz.Avaliar (jogada1, jogada2);

			Assert.AreEqual (Resultado.Pedra, avaliacao);
		}

		[TestCase(Jogada.Papel, Jogada.Tesoura)]
		[TestCase(Jogada.Tesoura, Jogada.Papel)]
		public void TestaSeRetornaTesouraAoCompararTesoura_E_Papel(Jogada jogada1, Jogada jogada2)
		{
			var avaliacao = juiz.Avaliar (jogada1, jogada2);

			Assert.AreEqual (Resultado.Tesoura, avaliacao);
		}

		[TestCase(Jogada.Papel, Jogada.Pedra)]
		[TestCase(Jogada.Pedra, Jogada.Papel)]
		public void TestaSeRetornaPapelAoCompararPapel_E_Pedra(Jogada jogada1, Jogada jogada2)
		{
			var avaliacao = juiz.Avaliar (jogada1, jogada2);

			Assert.AreEqual (Resultado.Papel, avaliacao);
		}
	}
}
	