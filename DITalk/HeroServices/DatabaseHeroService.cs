using System.Collections.Generic;

namespace DITalk.HeroServices
{
	public class DatabaseHeroService : IHeroService
	{
		public IEnumerable<SuperHero> GetHeroes()
		{
			return new List<SuperHero>()
			{
				new SuperHero { Universe = Universe.Marvel, HeroName = "Black Widow", FirstName = "Natasha", LastName = "Romanovo", AttackStrength = 60, DefenseStrength = 60, SpecialMove = "Face kick!", NightModifier = 1.2m, UnderwaterModifier = 0.5m, ZeroGravityModifier = 1.0m},
				new SuperHero { Universe = Universe.Marvel, HeroName = "Captain America", FirstName = "Steve", LastName = "Rogers", AttackStrength = 105, DefenseStrength = 200, SpecialMove = "Throws shield!", NightModifier = 1.0m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 1.0m},
				new SuperHero { Universe = Universe.Marvel, HeroName = "Cyclops", FirstName = "Scott", LastName = "Summers", AttackStrength = 360, DefenseStrength = 70, SpecialMove = "Shoots laser beam from eyes!", NightModifier = 1.0m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 1.0m},
				new SuperHero { Universe = Universe.Marvel, HeroName = "Daredevil", FirstName = "Matt", LastName = "Murdock", AttackStrength = 50, DefenseStrength = 60, SpecialMove = "Yells Insult!", NightModifier = 1.0m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 1.0m},
				new SuperHero { Universe = Universe.Marvel, HeroName = "Hawkeye", FirstName = "Clint", LastName = "Barton", AttackStrength = 140, DefenseStrength = 40, SpecialMove = "Shoots explosive arrow!", NightModifier = 1.0m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 1.0m},
				new SuperHero { Universe = Universe.Marvel, HeroName = "Hulk", FirstName = "Bruce", LastName = "Banner", AttackStrength = 300, DefenseStrength = 400, SpecialMove = "Smash!", NightModifier = 1.0m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 0.5m},
				new SuperHero { Universe = Universe.Marvel, HeroName = "Human Torch", FirstName = "Johnny", LastName = "Storm", AttackStrength = 120, DefenseStrength = 75, SpecialMove = "Flame On!", NightModifier = 0.6m, UnderwaterModifier = 0.2m, ZeroGravityModifier = 1.0m},
				new SuperHero { Universe = Universe.Marvel, HeroName = "Ironman", FirstName = "Tony", LastName = "Stark", AttackStrength = 90, DefenseStrength = 90, SpecialMove = "Energy blast!", NightModifier = 1.25m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 1.0m},
				new SuperHero { Universe = Universe.Marvel, HeroName = "Spiderman", FirstName = "Peter", LastName = "Parker", AttackStrength = 40, DefenseStrength = 170, SpecialMove = "Shoots web!", NightModifier = 1.4m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 1.0m},
				new SuperHero { Universe = Universe.Marvel, HeroName = "Storm", FirstName = "Ororo", LastName = "Monrow", AttackStrength = 50, DefenseStrength = 70, SpecialMove = "Lightning Stike!", NightModifier = 1.0m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 1.0m},
				new SuperHero { Universe = Universe.Marvel, HeroName = "Wolverine", FirstName = "Jame", LastName = "Howlett", AttackStrength = 110, DefenseStrength = 200, SpecialMove = "Claw slash!", NightModifier = 1.0m, UnderwaterModifier = 0.3m, ZeroGravityModifier = 1.0m},
			};
		}
	}
}