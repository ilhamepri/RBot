﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot
{
    public partial class OptionsForm : HideForm
    {
        public OptionsForm()
        {
            InitializeComponent();

            Bot.Options.BindControl("InfiniteRange", chkInfiniteRange);
            Bot.Options.BindControl("AggroMonsters", chkAggro);
            Bot.Options.BindControl("Magnetise", chkMagnet);
            Bot.Options.BindControl("PrivateRooms", chkPrivRooms);
            Bot.Options.BindControl("SkipCutscenes", chkSkipCutscenes);
            Bot.Options.BindControl("LagKiller", chkLagKiller);
            Bot.Options.BindControl("HidePlayers", chkHidePlayers);
            Bot.Options.BindControl("AcceptAll", chkAcceptAll);
            Bot.Options.BindControl("RejectAll", chkRejectAll);
            Bot.Options.BindControl("DisableFX", chkDisableFX);
            Bot.Options.BindControl("DisableCollisions", chkDisableCols);
            Bot.Options.BindControl("WalkSpeed", numWalkSpeed);
        }

        private void btnSetFpsCap_Click(object sender, EventArgs e)
        {
            Bot.SetGameObject("stage.frameRate", (int)numFpsCap.Value);
        }

        private void btnSetName_Click(object sender, EventArgs e)
        {
            Bot.Options.CustomName = txtCustomName.Text;
        }

        private void btnSetGuild_Click(object sender, EventArgs e)
        {
            Bot.Options.CustomGuild = txtCustomGuild.Text;
        }

        private void chkUpgrade_CheckedChanged(object sender, EventArgs e)
        {
            Bot.Player.Upgrade = chkUpgrade.Checked;
        }

        private void chkStaff_CheckedChanged(object sender, EventArgs e)
        {
            Bot.Player.AccessLevel = chkUpgrade.Checked ? 100 : 10;
        }

        private void chkFpsCounter_CheckedChanged(object sender, EventArgs e)
        {
            Bot.CallGameFunction("world.toggleFPS");
        }
    }
}
