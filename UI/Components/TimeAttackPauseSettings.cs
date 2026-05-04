// Copyright (c) aicd0. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Windows.Forms;
using System.Xml;

using LiveSplit.UI;

namespace LiveSplit.TimeAttackPause.UI.Components;

public partial class TimeAttackPauseSettings : UserControl
{
    public LayoutMode Mode { get; set; }

    public TimeAttackPauseSettings()
    {
        InitializeComponent();
    }

    private void TimeAttackPauseSettings_Load(object sender, EventArgs e)
    {

    }

    private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    public XmlNode GetSettings(XmlDocument document)
    {
        XmlElement parent = document.CreateElement("Settings");
        CreateSettingsNode(document, parent);
        return parent;
    }

    public void SetSettings(XmlNode node)
    {
        var element = (XmlElement)node;
        DefaultSavePath = SettingsHelper.ParseString(element["DefaultSavePath"]);
    }

    public int GetSettingsHashCode()
    {
        return CreateSettingsNode(null, null);
    }

    private int CreateSettingsNode(XmlDocument? document, XmlElement? parent)
    {
        return SettingsHelper.CreateSetting(document, parent, "Version", "1.0") ^
            SettingsHelper.CreateSetting(document, parent, "DefaultSavePath", DefaultSavePath);
    }
}
