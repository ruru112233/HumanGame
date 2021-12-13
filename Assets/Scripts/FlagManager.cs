using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CheckPoint
{
    public static class FlagManager
    {
        public static bool crearFlag = false;
        public static bool blackKeyFlag = false; // クリア用のキー

        public static bool blueKeyFlag = false;
        public static bool greenKeyFlag = false;
        public static bool redKeyFlag = false;

        public static void FlagOff()
        {
            blackKeyFlag = false;
            blueKeyFlag = false;
            greenKeyFlag = false;
            redKeyFlag = false;
        }
    }

}
