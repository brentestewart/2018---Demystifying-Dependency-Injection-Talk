using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiTalk.Fight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DITalk.Tests
{
	[TestClass]
	public class BattleAnalyzerTests
	{
		[TestMethod]
		public void Research_WhenHero1AlwaysWinsInTheFightAlgorithm_Hero1ShouldWinTheBattle()
		{
			var analyzer = new BattleAnalyzer();
			var winPercentage = analyzer.Reserch("Superman");

			Assert.AreEqual(1, winPercentage);
		}
	}
}
