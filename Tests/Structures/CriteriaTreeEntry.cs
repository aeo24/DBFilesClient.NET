using DBFilesClient.NET;

namespace Tests.Structures
{
    [DBFileName("CriteriaTree")]
    public sealed class CriteriaTreeEntry
    {
        public uint CriteriaID;
        public uint Amount;
        public string Description;
        public ushort Parent;
        public ushort Flags;
        public byte Operator;
        public uint OrderIndex;
    }
}