using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StockPanel : MonoBehaviour
{
    public List<Button> buttonList;

    public void panelSelectOff()
    {
        foreach (Button button in buttonList)
        {
            button.GetComponent<Image>().color = Color.white;
        }
    }

}
