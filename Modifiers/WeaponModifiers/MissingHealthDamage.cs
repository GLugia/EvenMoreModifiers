using Loot.Core.System;
using Microsoft.Xna.Framework;
using Terraria;

namespace Loot.Modifiers.WeaponModifiers
{
	public class MissingHealthDamage : WeaponModifier
	{
		public override ModifierTooltipLine[] TooltipLines => new[]
			{
				new ModifierTooltipLine { Text = $"Up to +{Properties.RoundedPower}% damage based on missing health", Color = Color.Lime}
			};

		public override ModifierPropertiesBuilder GetModifierProperties(Item item)
		{
			return base.GetModifierProperties(item)
				.WithMinMagnitude(5f)
				.WithMaxMagnitude(15f);
		}

		public override void GetWeaponDamage(Item item, Player player, ref int damage)
		{
			base.GetWeaponDamage(item, player, ref damage);
			// Formula ported from old mod
			float mag = (Properties.RoundedPower * ((player.statLifeMax2 - player.statLife) / (float)player.statLifeMax2));
			damage = (int)(damage * (1 + mag / 100));
		}
	}
}
