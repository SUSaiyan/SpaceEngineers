﻿using ProtoBuf;
using VRage.ObjectBuilders;

namespace VRage.Game.ObjectBuilders.ComponentSystem
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_CraftingComponentBase : MyObjectBuilder_ComponentBase
    {
        [ProtoMember]
        public long LockedByEntityId = -1;
    }
}
