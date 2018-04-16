using System.Collections.Generic;

namespace DITalk.HeroServices
{
	public interface IHeroService
	{
		IEnumerable<SuperHero> GetHeroes();
	}
}