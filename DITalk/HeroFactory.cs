using System.Collections.Generic;
using System.Linq;
using DITalk.HeroServices;

namespace DITalk
{

	public class HeroFactory
	{
		private IEnumerable<SuperHero> AllHeroes { get; set; }
		private IHeroService HeroService { get; set; }

		public HeroFactory()
		{
			HeroService = new WebHeroService();
			AllHeroes = HeroService.GetHeroes();
		}

		public IEnumerable<SuperHero> GetAllHeroes()
		{
			return AllHeroes;
		}

		public IEnumerable<SuperHero> GetDcHeroes()
		{
			return AllHeroes.Where(h => h.Universe == Universe.DC);
		}

		public IEnumerable<SuperHero> GetMarvelHeroes()
		{
			return AllHeroes.Where(h => h.Universe == Universe.Marvel);
		}

	}
}