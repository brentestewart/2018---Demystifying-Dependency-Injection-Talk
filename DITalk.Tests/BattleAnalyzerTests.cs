using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiTalk.Fight;
using DITalk.Arenas;
using DITalk.Factories;
using DITalk.FightAlgorithms;
using DITalk.HeroServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DITalk.Tests
{
	[TestClass]
	public class BattleAnalyzerTests
	{
		[TestMethod]
		public void Research_WhenHero1AlwaysWinsInTheFightAlgorithm_Hero1ShouldWin100PercentOfTheTime()
		{
			var hero1 = new SuperHero { HeroName = "Brent"};
			var heroList = new StaticHeroService().GetHeroes().ToList();
			heroList.Add(hero1);

			var mockFightAlgorithm = new Mock<IFightAlgorithm>();
			mockFightAlgorithm.Setup(a => a.Fight(It.IsAny<SuperHero>(), It.IsAny<SuperHero>(), It.IsAny<IArena>())).Returns(hero1);

			var mockHeroFactory = new Mock<IHeroFactory>();
			mockHeroFactory.Setup(f => f.GetAllHeroes()).Returns(heroList);

			var mockArena = new Mock<IArena>();
			var analyzer = new BattleAnalyzer(mockFightAlgorithm.Object, mockArena.Object, mockHeroFactory.Object);
			var winPercentage = analyzer.Reserch("Brent");

			Assert.AreEqual(1, winPercentage);
		}
	}
}
