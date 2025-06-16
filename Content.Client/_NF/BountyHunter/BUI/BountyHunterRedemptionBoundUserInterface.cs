using JetBrains.Annotations;
using Content.Client._NF.BountyHunter.UI;
using Content.Shared._NF.BountyHunter;
using Robust.Client.UserInterface;

namespace Content.Client._NF.BountyHunter.BUI;

[UsedImplicitly]
public sealed class BountyHunterRedemptionBoundUserInterface : BoundUserInterface
{
    [ViewVariables]
    private BountyHunterRedemptionMenu? _menu;

    public BountyHunterRedemptionBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
    {
    }

    protected override void Open()
    {
        base.Open();

        if (_menu == null)
        {
            _menu = this.CreateWindow<BountyHunterRedemptionMenu>();
            _menu.SellRequested += SendBountyMessage;
        }
    }

    private void SendBountyMessage()
    {
        SendMessage(new RedeemBountyHunterMessage());
    }

    protected override void UpdateState(BoundUserInterfaceState message)
    {
        base.UpdateState(message);

        if (message is not BountyHunterRedemptionUIState state)
            return;

        _menu?.UpdateState(state);
    }
}
