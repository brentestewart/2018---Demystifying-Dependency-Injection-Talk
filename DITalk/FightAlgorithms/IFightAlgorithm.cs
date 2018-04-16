using DITalk.Arenas;

namespace DITalk.FightAlgorithms
{
	public interface IFightAlgorithm
	{
		SuperHero Fight(SuperHero hero1, SuperHero hero2, IArena arena);
	}
}