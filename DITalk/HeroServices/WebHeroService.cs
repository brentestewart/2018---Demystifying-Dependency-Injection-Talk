using System.Collections.Generic;

namespace DITalk.HeroServices
{
	public class WebHeroService : IHeroService
	{
		public IEnumerable<SuperHero> GetHeroes()
		{
			return new List<SuperHero>()
			{
				new SuperHero { Universe = Universe.DC, HeroName = "Atom", FirstName = "Ray", LastName = "Palmer", AttackStrength = 100, DefenseStrength = 100, SpecialMove = "Shrink and attack!", NightModifier = 1.0m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 1.0m},
				new SuperHero { Universe = Universe.DC, HeroName = "Batman", FirstName = "Bruce", LastName = "Wayne", AttackStrength = 50, DefenseStrength = 120, SpecialMove = "Throws batarang!", NightModifier = 1.5m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 1.0m},
				new SuperHero { Universe = Universe.DC, HeroName = "Green Arrow", FirstName = "Oliver", LastName = "Queen", AttackStrength = 120, DefenseStrength = 45, SpecialMove = "Shoots arrow...", NightModifier = 1.0m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 1.0m},
				new SuperHero { Universe = Universe.DC, HeroName = "Green Lantern", FirstName = "Hal", LastName = "Jordan", AttackStrength = 200, DefenseStrength = 200, SpecialMove = "Punches with giant fist!", NightModifier = 1.0m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 2.0m},
				new SuperHero { Universe = Universe.DC, HeroName = "Hawkman", FirstName = "Carter", LastName = "Hall", AttackStrength = 95, DefenseStrength = 70, SpecialMove = "Swoops down and attacks!", NightModifier = 1.0m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 1.0m},
				new SuperHero { Universe = Universe.DC, HeroName = "Supergirl", FirstName = "Kara", LastName = "Zor-El", AttackStrength = 300, DefenseStrength = 300, SpecialMove = "Super Punch!", NightModifier = 1.0m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 1.0m},
				new SuperHero { Universe = Universe.DC, HeroName = "Superman", FirstName = "Clark", LastName = "Kent", AttackStrength = 350, DefenseStrength = 350, SpecialMove = "Shoots with laser eyes!", NightModifier = 1.0m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 2.0m},
				new SuperHero { Universe = Universe.DC, HeroName = "The Flash", FirstName = "Barry", LastName = "Allen", AttackStrength = 80, DefenseStrength = 300, SpecialMove = "Dodges with super speed!", NightModifier = 0.7m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 1.0m},
				new SuperHero { Universe = Universe.DC, HeroName = "Wonder Woman", FirstName = "Diana", LastName = "Prince", AttackStrength = 110, DefenseStrength = 80, SpecialMove = "Lassos with golden lasso of truth!", NightModifier = 1.0m, UnderwaterModifier = 1.0m, ZeroGravityModifier = 1.0m},
			};
		}
	}
}