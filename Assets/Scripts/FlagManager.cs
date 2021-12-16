using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CheckPoint
{
    public static class FlagManager
    {
        public static bool crearFlag = false;

        public static bool treasureFlag = false;
        public static bool blackKeyFlag = false; // �N���A�p�̃L�[

        public static bool blueKeyFlag = false;
        public static bool greenKeyFlag = false;
        public static bool redKeyFlag = false;

        // �d���X�C�b�`
        public static bool dengenOff = false; // �d�������Ă��邩�̃t���O
        public static bool dengenFlag = false; // �d���������邩�̃t���O

        // �v���C���[�̐���
        public static bool playerStop = false;

        // �؂̖_����ɓ��ꂽ�t���O
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
