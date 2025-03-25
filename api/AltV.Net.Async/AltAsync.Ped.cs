using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using System.Threading.Tasks;

namespace AltV.Net.Async
{
    public static partial class AltAsync
    {
        public static Task<IPed> CreatePed(uint model, Position pos, Rotation rot, uint streamingDistance = 0, bool isStatic = false) => AltVAsync.Schedule(() =>
            Alt.CoreImpl.CreatePed(model, pos, rot, streamingDistance, isStatic));

        public static Task<IPed> CreatePed(PedModel model, Position pos, Rotation rot, uint streamingDistance = 0, bool isStatic = false) =>
            CreatePed((uint)model, pos, rot, streamingDistance, isStatic);

        public static Task<IPed> CreatePed(string model, Position pos, Rotation rot, uint streamingDistance = 0, bool isStatic = false) =>
            CreatePed(Alt.Hash(model), pos, rot, streamingDistance, isStatic);

    }
}
