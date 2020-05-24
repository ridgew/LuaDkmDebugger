using System;

namespace LuaDkmDebuggerComponent
{
    static class Guids
    {
        public static readonly Guid luaLocalComponentGuid = new Guid("CF3F5D48-EFBB-49CB-916A-F19812A322ED");
        public static readonly Guid luaRemoteComponentGuid = new Guid("1A5CBF53-315C-4E2C-A790-4042F9435EB7");

        public static readonly Guid luaCompilerGuid = new Guid("DD79A808-7001-4458-99D9-469BB771B9B4");
        public static readonly Guid luaLanguageGuid = new Guid("C241D4C1-BC0C-45F7-99D3-D5264155BD05");
        public static readonly Guid luaRuntimeGuid = new Guid("A2D176A1-8907-483C-9B36-4544EF424967");
        public static readonly Guid luaSymbolProviderGuid = new Guid("00BB9B25-E5EA-4B0F-AD3D-C017B16F4FA1");

        public static readonly Guid luaUserBreakpointGuid = new Guid("3A5AA771-B853-43A7-8F0C-3088712605D8");
        public static readonly Guid luaSupportBreakpointGuid = new Guid("F8B5C32C-126E-49EC-979E-3AE10F8321FA");
    }

    static class MessageToRemote
    {
        public static readonly Guid guid = new Guid("ED25F587-E107-4F94-9775-885BEC371006");

        public static readonly int createRuntime = 1;
    }

    static class MessageToLocal
    {
        public static readonly Guid guid = new Guid("40C433F5-7EB9-400F-8DAC-DC4CAC739BE4");

        public static readonly int luaSupportBreakpointHit = 1;
    }
}
