
namespace Content.Shared._NF.BountyHunter.Components;

[RegisterComponent]
public sealed partial class BountyHunterTargetComponent : Component
{
    /// <summary>
    /// Defines how valuable a target is, tiered from 1 (moderate) to 4 (Ultra)
    /// Initialized as 0, and doesn't give anything at all unless defined higher.
    /// </summary>
    [DataField]
    public int BaseBountyValue = 0;

    /// <summary>
    /// Defines the value modifer, used as a multipler for BaseBountyValue.
    /// Initialized as 1.0x
    /// </summary>
    [DataField]
    public double BountyValueModifier = 1.0;

    /// <summary>
    /// Checks to see if the bounty has been critted or killed previously.
    /// 0 is 'healthy' ie, not critted or killed prior
    /// 1 is critted
    /// 2 is death
    /// It doesn't matter if the target is current in that state or not.
    /// </summary>

    [DataField]
    public int BountyBroughtBackAlive = 0;

}
