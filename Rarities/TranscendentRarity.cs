using Loot.Core.System.Modifier;
using Microsoft.Xna.Framework;

namespace Loot.Rarities
{
	public class TranscendentRarity : ModifierRarity
	{
		public override string RarityName => "Transcendent";
		public override Color Color => Color.Purple;

		public override float RequiredRarityLevel => 8f;
		//public override string ItemSuffix => "of the Transcendent";
	}
}
