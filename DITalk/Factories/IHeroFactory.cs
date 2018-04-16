using System.Collections.Generic;

namespace DITalk.Factories
{
	public interface IHeroFactory
	{
		IEnumerable<SuperHero> GetAllHeroes();
		IEnumerable<SuperHero> GetDcHeroes();
		IEnumerable<SuperHero> GetMarvelHeroes();
	}
}