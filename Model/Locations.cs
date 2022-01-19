using System.ComponentModel;

namespace TransportLy.Model
{
    public enum Locations
    {
        [Description("Montreal")]
        YUL,
        [Description("Vancouver")]
        YVR,
        [Description("Calgary")]
        YYC,
        [Description("Toronto")]
        YYZ,
    }
}
