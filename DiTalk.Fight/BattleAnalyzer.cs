using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITalk;
using DITalk.Arenas;
using DITalk.FightAlgorithms;

namespace DiTalk.Fight
{
	public class BattleAnalyzer
	{
		//public Battle Battle { get; set; } = new Battle();
		private IFightAlgorithm FightAlgorithm { get; set; }
		private IArena Arena { get; set; }

		public BattleAnalyzer()
		{
			FightAlgorithm = new ComplexFightAlgorithm();
			Arena = new ParkingLotArena();
		}

		public decimal Reserch(string heroName)
		{
			var wins = 0m;
			var battles = 0m;
			var heroFactory = new HeroFactory();

			var heroes = heroFactory.GetAllHeroes().ToList();

			var heroToAnalyze = heroes.First(h => h.HeroName == heroName);
			foreach (var currentHero in heroes)
			{
				battles++;
				if(currentHero == heroToAnalyze) continue;

				var winner = FightAlgorithm.Fight(heroToAnalyze, currentHero, Arena);
				Console.WriteLine($"{heroToAnalyze.HeroName} fights {currentHero.HeroName} - Winner is {winner.HeroName}!");
				if (winner == heroToAnalyze)
				{
					wins++;
				}
			}

			return wins / battles;
		}
	}
}
