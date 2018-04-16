namespace DITalk.Arenas
{
	public interface IArena
	{
		string Name { get; }
		bool IsDark { get; }
		bool IsUnderwater { get; }
		bool IsOuterSpace { get; }
	}
}