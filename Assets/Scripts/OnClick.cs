using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumScript;
using CheckPoint;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    public void ItemSelect()
    {
        if (gameObject.transform.GetComponent<Image>().sprite)
        {
            Image image = gameObject.transform.GetComponent<Image>();
            string imageName = image.sprite.name;
            GameManager.instance.stockPanel.panelSelectOff();
            image.color = Color.green;
            FlagChange(imageName);
        }

    }

    private void FlagChange(string imageName)
    {
        switch (imageName)
        {
            case "Black":
                FlagManager.FlagOff();
                FlagManager.blackKeyFlag = true;
                break;
            case "Blue":
                FlagManager.FlagOff();
                FlagManager.blueKeyFlag = true;
                break;
            case "Green":
                FlagManager.FlagOff();
                FlagManager.greenKeyFlag = true;
                break;
            case "Red":
                FlagManager.FlagOff();
                FlagManager.redKeyFlag = true;
                break;
        }
    }

}
