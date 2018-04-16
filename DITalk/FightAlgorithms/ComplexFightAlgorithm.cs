using System;
using DITalk.Arenas;

namespace DITalk.FightAlgorithms
{
	public class ComplexFightAlgorithm : IFightAlgorithm
	{
		public Random Random { get; set; }
		public ComplexFightAlgorithm()
		{
			Random = new Random();
		}
		public SuperHero Fight(SuperHero hero1, SuperHero hero2, IArena arena)
		{
			var winner = Random.Next(0, 2);
			return winner == 0 ? hero1 : hero2;
		}
	}
}