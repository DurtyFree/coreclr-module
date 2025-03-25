namespace AltV.Net.Elements.Entities;

public enum VoiceConnectionState : byte
{
    Disconnected,
    Connecting,
    RequestingConnect,
    Redirecting,
    RequestingRedirectConnect,
    Connected
}