using Microsoft.Xna.Framework.Graphics;
using MagicSkillCode.Core;

namespace MagicSkillCode.Framework
{
    public class Content
    {
        /*********
        ** Public methods
        *********/
        public static Texture2D LoadTexture(string path)
        {
            return ModEntry.Instance.Helper.ModContent.Load<Texture2D>($"Assets/{path}");
        }

        public static string LoadTextureKey(string path)
        {
            return ModEntry.Instance.Helper.ModContent.GetInternalAssetName($"Assets/{path}").BaseName;
        }
    }
}
