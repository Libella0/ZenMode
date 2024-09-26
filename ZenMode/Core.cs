using MelonLoader;

[assembly: MelonInfo(typeof(ZenMode.Core), "ZenMode", "1.0.0", "valer", null)]
[assembly: MelonGame("Little Flag Software, LLC", "Neon White")]

namespace ZenMode
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            //Hi :3
            LoggerInstance.Msg("Initialized.");
        }
    }
}