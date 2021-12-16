using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CheckPoint
{
    public class FlagManager
    {
        public static bool crearFlag = false;

        public static bool treasureFlag = false;
        public static bool blackKeyFlag = false; // �N���A�p�̃L�[

        public static bool blueKeyFlag = false;
        public static bool greenKeyFlag = false;
        public static bool redKeyFlag = false;

        // �d���X�C�b�`
        public static bool dengenOn = false; // �d�������Ă��邩�̃t���O
        public static bool dengenFlag = false; // �d���������邩�̃t���O

        // �v���C���[�̐���
        public static bool playerStop = false;


        public static void OffFlagAll() 
        {
            crearFlag = false;
            treasureFlag = false;
            blackKeyFlag = false;
            blueKeyFlag = false;
            greenKeyFlag = false;
            redKeyFlag = false;
            dengenOn = false;
            dengenFlag = false;
            playerStop = false;

        }

        public static void FlagOff()
        {
            blackKeyFlag = false;
            blueKeyFlag = false;
            greenKeyFlag = false;
            redKeyFlag = false;
        }
    }

}
