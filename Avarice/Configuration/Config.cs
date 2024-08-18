﻿using Dalamud.Configuration;

namespace Avarice.Configuration;

[Serializable]
internal class Config : IPluginConfiguration
{
    public int Version { get; set; } = 1;

    public uint ActionEffect1Opcode = 0x398;
    public List<Profile> Profiles = [];
    public Dictionary<uint, string> JobProfiles = [];

    public Vector4 DutyMidPixelCol = EColor.YellowBright;
    public float DutyMidRadius = 1f;
    public Vector4 CenteredPixelColor = EColor.GreenBright;
    public Vector4 UncenteredPixelColor = EColor.RedBright;
    public float CenterPixelThickness = 2f;

    public Dictionary<uint, Vector3?> DutyMiddleOverrides = [];

    public List<ExtraPoint> DutyMiddleExtras = [];
    public bool SplatoonUnsafePixel = false;
    public Vector4 SplatoonPixelCol = EColor.RedBright;
}
