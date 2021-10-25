using System;

using FFXIVClientStructs.FFXIV.Client.UI;

namespace ClickLib.Clicks
{
    public sealed unsafe class ClickVoteMvp : ClickAddonBase<AddonVoteMvp>
    {

        protected override string AddonName => "VoteMvp";

        public ClickVoteMvp(IntPtr addon = default)
            : base(addon)
        {
        }

        [ClickName("votemvp_button")]
        public void Vote() => ClickAddonButton(&this.Addon->AtkUnitBase, this.Addon->VoteButton, 0U);

        [ClickName("player1_checkbox")]
        public void CheckPlayer1() => ClickAddonCheckBox(&this.Addon->AtkUnitBase, this.Addon->check1, 3U);

        [ClickName("player2_checkbox")]
        public void CheckPlayer2() => ClickAddonCheckBox(&this.Addon->AtkUnitBase, this.Addon->check2, 3U);

        [ClickName("player3_checkbox")]
        public void CheckPlayer3() => ClickAddonCheckBox(&this.Addon->AtkUnitBase, this.Addon->check3, 3U);

        [ClickName("player4_checkbox")]
        public void CheckPlayer4() => ClickAddonCheckBox(&this.Addon->AtkUnitBase, this.Addon->check4, 3U);

        [ClickName("player5_checkbox")]
        public void CheckPlayer5() => ClickAddonCheckBox(&this.Addon->AtkUnitBase, this.Addon->check5, 3U);

        [ClickName("player6_checkbox")]
        public void CheckPlayer6() => ClickAddonCheckBox(&this.Addon->AtkUnitBase, this.Addon->check6, 3U);

        [ClickName("player7_checkbox")]
        public void CheckPlayer7() => ClickAddonCheckBox(&this.Addon->AtkUnitBase, this.Addon->check7, 3U);
    }
}
