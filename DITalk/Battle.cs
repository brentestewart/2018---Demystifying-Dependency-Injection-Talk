using DITalk.Arenas;
using DITalk.FightAlgorithms;

namespace DITalk
{
	public class Battle
	{
		private IFightAlgorithm FightAlgorithm { get; set; } = new ComplexFightAlgorithm();
		private IArena Arena { get; set; } = new ParkingLotArena();

		public SuperHero Fight(SuperHero hero1, SuperHero hero2, int numberOfFights)
		{
			var hero1Wins = 0;
			for (int i = 0; i < numberOfFights; i++)
			{
				var winner = FightAlgorithm.Fight(hero1, hero2, Arena);
				hero1Wins += (winner == hero1) ? 1 : -1;
			}

			return (hero1Wins > 0) ? hero1 : hero2;
		}
	}
}