using System;
using Terraria;
using Terraria.ModLoader;

namespace Loot.Sounds
{
	internal static class SoundHelper
	{
		internal enum SoundType
		{
			CloseUI,
			Decline,
			Notif,
			OpenUI,
			Receive,
			Redeem,
			GainSeal,
			LoseSeal
		}

		internal static void PlayCustomSound(SoundType type)
		{
			Main.PlaySound(SoundLoader.customSoundType, -1, -1,
				Loot.Instance.GetSoundSlot(
					Terraria.ModLoader.SoundType.Custom,
					"Sounds/Custom/" + Enum.GetName(typeof(SoundType), type)));
		}
	}
}
