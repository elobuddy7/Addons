using EloBuddy;

namespace BottingMode
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Hacks.DisableTextures = true;
            Hacks.AntiAFK = true;
            Hacks.RenderWatermark = false;

            ManagedTexture.OnLoad += ManagedTexture_OnLoad;
        }

        private static void ManagedTexture_OnLoad(OnLoadTextureEventArgs args)
        {
            args.Process = false;
        }
    }
}
