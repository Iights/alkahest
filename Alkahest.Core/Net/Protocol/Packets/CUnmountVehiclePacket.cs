namespace Alkahest.Core.Net.Protocol.Packets
{
    public sealed class CUnmountVehiclePacket : Packet
    {
        const string Name = "C_UNMOUNT_VEHICLE";

        public override string OpCode => Name;

        [Packet(Name)]
        internal static Packet Create()
        {
            return new CUnmountVehiclePacket();
        }
    }
}
