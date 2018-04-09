using Terraria.ModLoader;

namespace MagicStorage
{
	class MagicStorage : Mod
	{
		public MagicStorage()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
