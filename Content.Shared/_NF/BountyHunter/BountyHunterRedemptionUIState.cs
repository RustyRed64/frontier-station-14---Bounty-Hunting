using Robust.Shared.Serialization;

namespace Content.Shared._NF.BountyHunter;

[Serializable, NetSerializable]
public enum BountyHunterRedemptionUiKey : byte
{
    Key
}

[Serializable, NetSerializable]
public enum BountyHunterRedemptionStatus : byte
{
    NoBody,
    NoBounty,
    Critted,
    Died,
    Valid,
}

[Serializable, NetSerializable]
public enum BountyHunterRedemptionVisuals : byte
{
    Full
}

[Serializable, NetSerializable]
public sealed class BountyHunterRedemptionUIState : BoundUserInterfaceState
{
    public int BountyValue { get; }
    public BountyHunterRedemptionStatus BountyStatus { get; }
    public bool PaidToStation { get; }

    public BountyHunterRedemptionUIState(BountyHunterRedemptionStatus bountyStatus, int bountyValue, bool paidToStation)
    {
        BountyStatus = bountyStatus;
        BountyValue = bountyValue;
        PaidToStation = paidToStation;
    }
}
