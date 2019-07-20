namespace Loot.Api.Attributes
{
	/// <summary>
	/// Defines a target that can be used in conjunction with <see cref="AutoDelegation"/>
	/// for identifying the target event
	/// </summary>
	public enum DelegationTarget
	{
		AnglerQuestReward,
		CanBeHitByNPC,
		CanBeHitByProjectile,
		CanHitNPC,
		CanHitNPCWithProj,
		CanHitPvp,
		CanHitPvpWithProj,
		ConsumeAmmo,
		CatchFish,
		DrawEffects,
		GetDyeTraderReward,
		GetFishingLevel,
		GetHealLife,
		GetHealMana,
		GetWeaponCrit,
		GetWeaponKnockback,
		Hurt,
		Initialize,
		Kill,
		MeleeEffects,
		MeleeSpeedMultiplier,
		ModifyDrawHeadLayers,
		ModifyDrawInfo,
		ModifyDrawLayers,
		ModifyHitByNPC,
		ModifyHitByProjectile,
		ModifyHitNPC,
		ModifyHitNPCWithProj,
		ModifyHitPvp,
		ModifyHitPvpWithProj,
		ModifyNurseHeal,
		ModifyNursePrice,
		ModifyScreenPosition,
		ModifyWeaponDamage,
		ModifyManaCost,
		ModifyZoom,
		NaturalLifeRegen,
		OnConsumeAmmo,
		OnHitAnything,
		OnHitByNPC,
		OnHitByProjectile,
		OnHitNPC,
		OnHitNPCWithProj,
		OnHitPvp,
		OnHitPvpWithProj,
		OnRespawn,
		PostHurt,
		PostUpdate,
		PostUpdateBuffs,
		PostUpdateEquips,
		PostUpdateMiscEffects,
		PostUpdateRunSpeeds,
		PreHurt,
		PreKill,
		PreUpdate,
		PreUpdateBuffs,
		PreUpdateMovement,
		ProcessTriggers,
		ResetEffects,
		Shoot,
		UpdateAutopause,
		UpdateBadLifeRegen,
		UpdateDead,
		UpdateEquips,
		UpdateLifeRegen,
		UpdateVanityAccessories,
		UseTimeMultiplier
	}
}
