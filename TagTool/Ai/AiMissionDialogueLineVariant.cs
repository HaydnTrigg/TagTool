using TagTool.Cache;
using TagTool.Common;
using TagTool.Tags;

namespace TagTool.Ai
{
    [TagStructure(Size = 0x18)]
    public class AiMissionDialogueLineVariant : TagStructure
	{
        [TagField(Label = true)]
        public StringId Designation;
        public CachedTagInstance Sound;
        public StringId SoundEffect;
    }
}
