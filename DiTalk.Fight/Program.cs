using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITalk.Arenas;
using DITalk.Factories;
using DITalk.FightAlgorithms;

namespace DiTalk.Fight
{
	class Program
	{
		static void Main(string[] args)
		{
			var analyzer = new BattleAnalyzer(new ComplexFightAlgorithm(), new ParkingLotArena(), new HeroFactory());
			var supermanWinPercentage = analyzer.Reserch("Superman");
			Console.WriteLine($"Superman won {supermanWinPercentage:#%}{Environment.NewLine}");

			var greenLanternWinPercentage = analyzer.Reserch("Green Lantern");
			Console.WriteLine($"Green Lantern won {greenLanternWinPercentage:#%}{Environment.NewLine}");

			Console.ReadKey();
		}
	}
}
