using System.Numerics;
using AltV.Net.Client.Elements.Data;
using AltV.Net.Client.Elements.Interfaces;
using AltV.Net.Data;

namespace AltV.Net.Client
{
    public static partial class Alt
    {
        public static Vector3 ScreenToWorld(Vector2 position) => CoreImpl.ScreenToWorld(position);
        public static Vector3 ScreenToWorld(float x, float y) => CoreImpl.ScreenToWorld(new Vector2(x, y));
        public static Vector2 WorldToScreen(Vector3 position) => CoreImpl.WorldToScreen(position);
        public static Vector2 WorldToScreen(float x, float y, float z) => CoreImpl.WorldToScreen(new Vector3(x, y, z));
        public static void ShowCursor(bool state) => CoreImpl.ShowCursor(state);
        public static bool IsCursorVisible => CoreImpl.IsCursorVisible;
        public static void AddGxtText(uint key, string value) => CoreImpl.AddGxtText(key, value);
        public static void AddGxtText(string key, string value) => CoreImpl.AddGxtText(Hash(key), value);
        public static string GetGxtText(uint key) => CoreImpl.GetGxtText(key);
        public static string GetGxtText(string key) => CoreImpl.GetGxtText(Hash(key));
        public static void RemoveGxtText(uint key) => CoreImpl.RemoveGxtText(key);
        public static void RemoveGxtText(string key) => CoreImpl.RemoveGxtText(Hash(key));
        public static bool BeginScaleformMovieMethodMinimap(string methodName) => CoreImpl.BeginScaleformMovieMethodMinimap(methodName);
        public static void SetMinimapComponentPosition(string name, char alignX, char alignY, float posX, float posY, float sizeX, float sizeY) => CoreImpl.SetMinimapComponentPosition(name, alignX, alignY, posX, posY, sizeX, sizeY);
        public static void SetMinimapComponentPosition(string name, char alignX, char alignY, Vector2 pos, Vector2 size) => CoreImpl.SetMinimapComponentPosition(name, alignX, alignY, pos.X, pos.Y, size.X, size.Y);
        public static void CopyToClipboard(string content) => CoreImpl.CopyToClipboard(content);
        public static bool GetPermissionState(Permission permission) => CoreImpl.GetPermissionState(permission);
        public static bool IsTextureExistInArchetype(uint modelHash, string targetTextureName) => CoreImpl.IsTextureExistInArchetype(modelHash, targetTextureName);
        public static bool IsTextureExistInArchetype(string modelName, string targetTextureName) => CoreImpl.IsTextureExistInArchetype(Hash(modelName), targetTextureName);
        public static bool IsPointOnScreen(Vector3 position) => CoreImpl.IsPointOnScreen(position);
        public static bool IsFullScreen() => CoreImpl.IsFullScreen;
        public static void LoadRmlFont(string path, string name, bool italic = false, bool bold = false) => CoreImpl.LoadRmlFont(path, name, italic, bold);
        public static void LoadModel(uint modelHash) => CoreImpl.LoadModel(modelHash);
        public static void LoadModel(string modelName) => CoreImpl.LoadModel(Hash(modelName));
        public static void LoadModelAsync(uint modelHash) => CoreImpl.LoadModelAsync(modelHash);
        public static void LoadModelAsync(string modelName) => CoreImpl.LoadModelAsync(Hash(modelName));
        public static bool LoadYtyp(string ytypName) => CoreImpl.LoadYtyp(ytypName);
        public static bool UnloadYtyp(string ytypName) => CoreImpl.UnloadYtyp(ytypName);
        public static void RequestIpl(string iplName) => CoreImpl.RequestIpl(iplName);
        public static void RemoveIpl(string iplName) => CoreImpl.RemoveIpl(iplName);
        public static bool IsKeyDown(Key key) => CoreImpl.IsKeyDown(key);
        public static bool IsKeyToggled(Key key) => CoreImpl.IsKeyToggled(key);
        public static bool DoesConfigFlagExist(string flagName) => CoreImpl.DoesConfigFlagExist(flagName);
        public static bool GetConfigFlag(string flagName) => CoreImpl.GetConfigFlag(flagName);
        public static void SetConfigFlag(string flagName, bool value) => CoreImpl.SetConfigFlag(flagName, value);
        public static Vector2 GetCursorPos(bool normalized) => CoreImpl.GetCursorPos(normalized);
        public static void SetCursorPos(Vector2 pos, bool normalized) => CoreImpl.SetCursorPos(pos, normalized);
        public static string GetStatType(string stat) => CoreImpl.GetStatType(stat);
        public static void ResetStat(string stat) => CoreImpl.ResetStat(stat);
        public static void GetStat(string stat, out int value) => CoreImpl.GetStat(stat, out value);
        public static void GetStat(string stat, out long value) => CoreImpl.GetStat(stat, out value);
        public static void GetStat(string stat, out float value) => CoreImpl.GetStat(stat, out value);
        public static void GetStat(string stat, out bool value) => CoreImpl.GetStat(stat, out value);
        public static void GetStat(string stat, out string value) => CoreImpl.GetStat(stat, out value);
        public static void GetStat(string stat, out byte value) => CoreImpl.GetStat(stat, out value);
        public static void GetStat(string stat, out ushort value) => CoreImpl.GetStat(stat, out value);
        public static void GetStat(string stat, out uint value) => CoreImpl.GetStat(stat, out value);
        public static void GetStat(string stat, out ulong value) => CoreImpl.GetStat(stat, out value);
        public static void SetStat(string stat, int value) => CoreImpl.SetStat(stat, value);
        public static void SetStat(string stat, long value) => CoreImpl.SetStat(stat, value);
        public static void SetStat(string stat, float value) => CoreImpl.SetStat(stat, value);
        public static void SetStat(string stat, bool value) => CoreImpl.SetStat(stat, value);
        public static void SetStat(string stat, string value) => CoreImpl.SetStat(stat, value);
        public static void SetStat(string stat, byte value) => CoreImpl.SetStat(stat, value);
        public static void SetStat(string stat, ushort value) => CoreImpl.SetStat(stat, value);
        public static void SetStat(string stat, uint value) => CoreImpl.SetStat(stat, value);
        public static void SetStat(string stat, ulong value) => CoreImpl.SetStat(stat, value);
        public static void ClearPedProp(int scriptId, byte component) => CoreImpl.ClearPedProp(scriptId, component);
        public static void SetPedDlcProp(int scriptId, uint dlc, byte component, byte drawable, byte texture) => CoreImpl.SetPedDlcProp(scriptId, dlc, component, drawable, texture);
        public static void SetPedDlcClothes(int scriptId, uint dlc, byte component, byte drawable, byte texture, byte palette) => CoreImpl.SetPedDlcClothes(scriptId, dlc, component, drawable, texture, palette);
        public static void SetRotationVelocity(int scriptId, Rotation velocity) => CoreImpl.SetRotationVelocity(scriptId, velocity);
        public static void SetWatermarkPosition(WatermarkPosition position) => CoreImpl.SetWatermarkPosition(position);
        public static string StringToSha256(string value) => CoreImpl.StringToSha256(value);
        public static void SetWeatherCycle(byte[] weathers, byte[] multipliers) => CoreImpl.SetWeatherCycle(weathers, multipliers);
        public static void SetWeatherSyncActive(bool state) => CoreImpl.SetWeatherSyncActive(state);
        public static string GetHeadshotBase64(byte id) => CoreImpl.GetHeadshotBase64(id);
        public static Task<string> TakeScreenshot() => CoreImpl.TakeScreenshot();
        public static Task<string> TakeScreenshotGameOnly() => CoreImpl.TakeScreenshotGameOnly();
        public static void RegisterFont(string path) => CoreImpl.RegisterFont(path);

        public static uint GetPoolSize(string pool) => CoreImpl.GetPoolSize(pool);
        public static uint GetPoolCount(string pool) => CoreImpl.GetPoolCount(pool);
        public static uint[] GetPoolEntities(string pool) => CoreImpl.GetPoolEntities(pool);

        public static uint[] GetVoicePlayers() => CoreImpl.GetVoicePlayers();
        public static void RemoveVoicePlayer(uint playerRemoteId) => CoreImpl.RemoveVoicePlayer(playerRemoteId);
        public static float GetVoiceSpatialVolume(uint playerRemoteId) => CoreImpl.GetVoiceSpatialVolume(playerRemoteId);
        public static void SetVoiceSpatialVolume(uint playerRemoteId, float volume) => CoreImpl.SetVoiceSpatialVolume(playerRemoteId, volume);
        public static float GetVoiceNonSpatialVolume(uint playerRemoteId) => CoreImpl.GetVoiceNonSpatialVolume(playerRemoteId);
        public static void SetVoiceNonSpatialVolume(uint playerRemoteId, float volume) => CoreImpl.SetVoiceNonSpatialVolume(playerRemoteId, volume);

        public static void AddVoiceFilter(uint playerRemoteId, IAudioFilter filter) => CoreImpl.AddVoiceFilter(playerRemoteId, filter);
        public static void RemoveVoiceFilter(uint playerRemoteId) => CoreImpl.RemoveVoiceFilter(playerRemoteId);
        public static IAudioFilter GetVoiceFilter(uint playerRemoteId) => CoreImpl.GetVoiceFilter(playerRemoteId);

        public static void UpdateClipContext(Dictionary<string, string> context) => CoreImpl.UpdateClipContext(context);

        public static MapZoomData GetMapZoomData(uint id) => CoreImpl.GetMapZoomData(id);
        public static MapZoomData GetMapZoomData(string alias) => CoreImpl.GetMapZoomData(alias);
        public static void ResetAllMapZoomData() => CoreImpl.ResetAllMapZoomData();
        public static void LoadDefaultIpls() => CoreImpl.LoadDefaultIpls();
        public static bool MinimapIsRectangle { set => CoreImpl.MinimapIsRectangle = value; }
        public static ushort Fps => CoreImpl.Fps;
        public static ushort Ping => CoreImpl.Ping;
        public static uint TotalPacketsLost => CoreImpl.TotalPacketsLost;
        public static ulong TotalPacketsSent => CoreImpl.TotalPacketsSent;
        public static Vector2 ScreenResolution => CoreImpl.ScreenResolution;
        public static string LicenseHash => CoreImpl.LicenseHash;
        public static string Locale => CoreImpl.Locale;
        public static string ServerIp => CoreImpl.ServerIp;
        public static ushort ServerPort => CoreImpl.ServerPort;
        public static bool IsGameFocused => CoreImpl.IsGameFocused;
        public static bool IsInStreamerMode => CoreImpl.IsInStreamerMode;
        public static bool IsMenuOpened => CoreImpl.IsMenuOpened;
        public static bool IsConsoleOpen => CoreImpl.IsConsoleOpen;
        public static bool CamFrozen { get => CoreImpl.CamFrozen; set => CoreImpl.CamFrozen = value; }
        public static Vector3 CamPos => CoreImpl.CamPos;
        public static bool GameControlsEnabled { get => CoreImpl.GameControlsEnabled; set => CoreImpl.GameControlsEnabled = value; }
        public static bool RmlControlsEnabled { get => CoreImpl.RmlControlsEnabled; set => CoreImpl.RmlControlsEnabled = value; }
        public static bool VoiceControlsEnabled { get => CoreImpl.VoiceControlsEnabled; set => CoreImpl.VoiceControlsEnabled = value; }
        public static int MsPerGameMinute { get => CoreImpl.MsPerGameMinute; set => CoreImpl.MsPerGameMinute = value; }

        public static ulong ServerTime => CoreImpl.ServerTime;

        public static bool ReloadVehiclePhysics(uint modelHash) => CoreImpl.ReloadVehiclePhysics(modelHash);
        public static double CpuLoad => CoreImpl.CpuLoad;
        public static uint VideoMemoryUsage => CoreImpl.VideoMemoryUsage;
        public static uint RamUsage => CoreImpl.RamUsage;
        public static uint TotalRam => CoreImpl.TotalRam;
        public static uint CurrentProcessRamUsage => CoreImpl.CurrentProcessRamUsage;
    }
}