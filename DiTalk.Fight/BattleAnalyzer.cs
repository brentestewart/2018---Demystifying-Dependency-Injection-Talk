using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITalk;
using DITalk.Arenas;
using DITalk.Factories;
using DITalk.FightAlgorithms;

namespace DiTalk.Fight
{
	public class BattleAnalyzer
	{
		private IFightAlgorithm FightAlgorithm { get; set; }
		private IArena Arena { get; set; }
		private IHeroFactory Factory { get; set; }

		public BattleAnalyzer(IFightAlgorithm fightAlgorithm, IArena arena, IHeroFactory heroFactory)
		{
			FightAlgorithm = fightAlgorithm;
			Arena = arena;
			Factory = heroFactory;
		}

		public decimal Reserch(string heroName)
		{
			var wins = 0m;
			var battles = 0m;

			var heroes = Factory.GetAllHeroes().ToList();

			var heroToAnalyze = heroes.First(h => h.HeroName == heroName);
			foreach (var currentHero in heroes)
			{
				if(currentHero == heroToAnalyze) continue;
				battles++;

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
