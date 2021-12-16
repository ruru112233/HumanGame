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
        FlagManager.FlagOff();

        switch (imageName)
        {
            case "Black":
                FlagManager.blackKeyFlag = true;
                break;
            case "Blue":
                FlagManager.blueKeyFlag = true;
                break;
            case "Green":
                FlagManager.greenKeyFlag = true;
                break;
            case "Red":
                FlagManager.redKeyFlag = true;
                break;
            case "bou":
                FlagManager.dengenFlag = true;
                break;
        }
    }

}
