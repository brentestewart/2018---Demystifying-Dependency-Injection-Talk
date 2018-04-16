using System.Collections.Generic;
using System.Linq;
using DITalk.HeroServices;

namespace DITalk.Factories
{
	public class HeroFactory : IHeroFactory
	{
		public IHeroService HeroService { get; set; } = new WebHeroService();

		public IEnumerable<SuperHero> GetAllHeroes()
		{
			return HeroService.GetHeroes();
		}

		public IEnumerable<SuperHero> GetDcHeroes()
		{
			return HeroService.GetHeroes().Where(h => h.Universe == Universe.DC);
		}

		public IEnumerable<SuperHero> GetMarvelHeroes()
		{
			return HeroService.GetHeroes().Where(h => h.Universe == Universe.Marvel);
		}

	}
}