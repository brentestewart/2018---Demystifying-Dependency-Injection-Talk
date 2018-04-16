using System;
using DITalk.Arenas;
using DITalk.FightAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DITalk.Tests
{
	[TestClass]
	public class BattleTest
	{
		public IFightAlgorithm Hero1AlwaysWinsAlgorithm { get; set; }
		public SuperHero Hero1 { get; set; }
		public SuperHero Hero2 { get; set; }

		[TestInitialize]
		public void SetupTests()
		{
			Hero1 = new SuperHero {AttackStrength = 100, DefenseStrength = 100};
			Hero2 = new SuperHero {AttackStrength = 50, DefenseStrength = 50};

			var moqAlgorithm = new Mock<IFightAlgorithm>();
			moqAlgorithm.Setup(a => a.Fight(It.IsAny<SuperHero>(), It.IsAny<SuperHero>(), It.IsAny<IArena>())).Returns(Hero1);
			Hero1AlwaysWinsAlgorithm = moqAlgorithm.Object;
		}

		[TestMethod]
		public void Fight_WhenHero1AlwaysWinsInTheFightAlgorithm_Hero1ShouldWinTheBattle()
		{
			// How can we force this to use our mock fight algorithm?
			var battle = new Battle();
			var winner = battle.Fight(Hero1, Hero2, 1);

			Assert.AreEqual(Hero1, winner);
		}
	}
}
