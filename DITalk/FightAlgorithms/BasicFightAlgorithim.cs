using DITalk.Arenas;

namespace DITalk.FightAlgorithms
{
	public class BasicFightAlgorithim : IFightAlgorithm
	{
		public SuperHero Fight(SuperHero hero1, SuperHero hero2, IArena arena)
		{
			decimal hero1Attack = hero1.AttackStrength;
			decimal hero2Attack = hero2.AttackStrength;

			if (arena.IsDark)
			{
				hero1Attack = hero1Attack * hero1.NightModifier;
				hero2Attack = hero2Attack * hero2.NightModifier;
			}

			if (arena.IsUnderwater)
			{
				hero1Attack = hero1Attack * hero1.UnderwaterModifier;
				hero2Attack = hero2Attack * hero2.UnderwaterModifier;
			}

			if (arena.IsOuterSpace)
			{
				hero1Attack = hero1Attack * hero1.ZeroGravityModifier;
				hero2Attack = hero2Attack * hero2.ZeroGravityModifier;
			}

			var hero1Hit = hero1Attack - hero2.DefenseStrength;
			var hero2Hit = hero2Attack - hero1.DefenseStrength;

			return (hero1Hit > hero2Hit) ? hero1 : hero2;
		}
	}
}