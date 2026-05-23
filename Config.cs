using CounterStrikeSharp.API.Core;
using System.Text.Json.Serialization;

namespace SeedCommand;

public sealed class SeedCommandConfig : BasePluginConfig
{
    [JsonPropertyName("DatabaseHost")]      public string DatabaseHost     { get; set; } = "127.0.0.1";
    [JsonPropertyName("DatabasePort")]      public int    DatabasePort     { get; set; } = 3306;
    [JsonPropertyName("DatabaseUser")]      public string DatabaseUser     { get; set; } = "weaponpaints";
    [JsonPropertyName("DatabasePassword")]  public string DatabasePassword { get; set; } = "cs2_local_pw";
    [JsonPropertyName("DatabaseName")]      public string DatabaseName     { get; set; } = "weaponpaints";

    // Path to WeaponPaints' English skins data file (used to populate menus).
    // Leave empty to auto-detect under the CS# plugins directory.
    [JsonPropertyName("SkinsJsonPath")]
    public string SkinsJsonPath { get; set; } = "";

    [JsonPropertyName("GlovesJsonPath")]
    public string GlovesJsonPath { get; set; } = "";

    // Force a fresh weapon spawn after applying a skin so the player sees the change instantly.
    // Requires sv_cheats 1 (server-side). Disable if you don't have cheats enabled.
    [JsonPropertyName("ForceWeaponRefresh")]
    public bool ForceWeaponRefresh { get; set; } = true;
}
