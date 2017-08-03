using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;

namespace Rquirrel_Ranger.Utilities
{
    public static class Ressources
    {
        public static Dictionary<string, Texture2D> Images;
        public static Dictionary<string, SoundEffect> Sfx;

        public static void LoadImage(ContentManager content)
        {
            Images = new Dictionary<string, Texture2D>();

            List<string> sprites = new List<string>()
            {
                "playerSprites",
                "frogSprites",
                "opossumSprites",
                "cherrySprites",
                "diamondSprites",
                "tileset"
            };

            foreach (string key in sprites)
            {
                Images.Add(key, content.Load<Texture2D>("Sprites/" + key));
            }

        }

        public static void LoadSounds(ContentManager content)
        {
            Sfx = new Dictionary<string, SoundEffect>();

            List<string> sounds = new List<string>()
            {

            };

            foreach (string key in sounds)
            {
                Sfx.Add(key, content.Load<SoundEffect>("Sounds/" + key));
            }
        }
    }
}
