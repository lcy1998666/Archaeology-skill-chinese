using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirbCore.Attributes;
using StardewModdingAPI;

namespace SpookySkill
{
    [SConfig]
    public class Config
    {

        [SConfig.Option()]
        public bool DeScary { get; set; } = false;

        [SConfig.Option(1, 3, 1)]
        public int ThiefIcon { get; set; } = 1;

        [SConfig.Option()]
        public bool MonstersOnly { get; set; } = false;

        [SConfig.Option()]
        public SButton Key_Cast { get; set; } = SButton.B;

        [SConfig.Option(0.0f, 50f, 1.0f)]
        public float ExpMod { get; set; } = 1f;

        [SConfig.Option(0, 100, 1)]
        public int ExpFromFail { get; set; } = 1;


        [SConfig.Option(0, 100, 14)]
        public int ExpLevel1 { get; set; } = 8;


        [SConfig.Option(0, 100, 28)]
        public int ExpLevel2 { get; set; } = 16;


        [SConfig.Option(0, 100, 42)]
        public int ExpLevel3 { get; set; } = 24;


        [SConfig.Option(0, 100, 56)]
        public int ExpLevel4 { get; set; } = 32;

    }
}
