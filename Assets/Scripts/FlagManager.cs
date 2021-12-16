using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CheckPoint
{
    public static class FlagManager
    {
        public static bool crearFlag = false;

        public static bool treasureFlag = false;
        public static bool blackKeyFlag = false; // クリア用のキー

        public static bool blueKeyFlag = false;
        public static bool greenKeyFlag = false;
        public static bool redKeyFlag = false;

        // 電源スイッチ
        public static bool dengenOff = false; // 電源がついているかのフラグ
        public static bool dengenFlag = false; // 電源がつけられるかのフラグ

        // プレイヤーの制御
        public static bool playerStop = false;

        // 木の棒を手に入れたフラグ
        public static bool getKinobou = false;


        public static void OffFlagAll() 
        {
            crearFlag = false;
            treasureFlag = false;
            blackKeyFlag = false;
            blueKeyFlag = false;
            greenKeyFlag = false;
            redKeyFlag = false;
            dengenOff = false;
            dengenFlag = false;
            playerStop = false;
            getKinobou = false;
        }

        public static void FlagOff()
        {
            blackKeyFlag = false;
            blueKeyFlag = false;
            greenKeyFlag = false;
            redKeyFlag = false;
            dengenFlag = false;
    }
    }

}
