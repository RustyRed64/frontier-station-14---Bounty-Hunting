using Robust.Shared.Audio;

namespace Content.Server._NF.BountyHunter;

/// <summary>
/// This is used on machines that can be used to redeem bounty bounties.
/// </summary>
[RegisterComponent]
public sealed partial class BountyHunterRedemptionComponent : Component
{
    /// <summary>
    /// The name of the container that holds bounty bounties to be redeemed.
    /// </summary>
    [DataField(required: true)]
    ///[DataField]
    public string Bounty_Container;

    /// <summary>
    /// The sound that plays when a bounty bounty is redeemed successfully.
    /// </summary>
    [DataField]
    public SoundSpecifier RedeemSound = new SoundPathSpecifier("/Audio/Effects/Cargo/ping.ogg");

    /// <summary>
    /// The sound that plays when a bounty bounty is unsuccessfully redeemed.
    /// </summary>
    [DataField]
    public SoundSpecifier DenySound = new SoundPathSpecifier("/Audio/Effects/Cargo/buzz_sigh.ogg");
}
