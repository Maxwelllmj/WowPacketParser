using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

namespace WowPacketParserModule.V8_0_1_27101.UpdateFields.V8_2_5_31921
{
    public class QuestSession : IQuestSession
    {
        public WowGuid Owner { get; set; }
        public ulong[] QuestCompleted { get; } = new ulong[875];
    }
}

