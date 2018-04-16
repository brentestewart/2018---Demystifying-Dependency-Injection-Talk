using System;

namespace DITalk
{
	public class SuperHero
    {
	    public string FirstName { get; set; }
	    public string LastName { get; set; }
	    public string HeroName { get; set; }
	    public Universe Universe { get; set; }
	    public int AttackStrength { get; set; }
	    public int DefenseStrength { get; set; }
	    public string SpecialMove { get; set; }
	    public decimal NightModifier { get; set; }
	    public decimal UnderwaterModifier { get; set; }
	    public decimal ZeroGravityModifier { get; set; }


	    public string Attack()
	    {
		    return $"Attacks with {AttackStrength}!";
	    }

	    public string Defend(int attackStrength)
	    {
		    if (DefenseStrength > attackStrength)
		    {
			    return $"Successfully defends attack!";
		    }
		    else
		    {
			    return $"Damaged by {AttackStrength - DefenseStrength}!";
		    }
	    }

	    public string DoSpecialMove()
	    {
		    return SpecialMove;
	    }
    }
}
