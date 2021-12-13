using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteManager : MonoBehaviour
{
    public List<Sprite> sprites;

    private int[] panels = new int[] { 0, 0, 0, 0 };

    public int[] Panels
    {
        get { return panels; }
        set { panels = value; }
    }

    StockPanel stockPanel;

    // Start is called before the first frame update
    void Start()
    {
        stockPanel = GameManager.instance.stockPanel;

        //PanelSet();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PanelSet(Sprite sprite, int keyNo)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            if (panels[i] == 0)
            {
                Panels[i] = keyNo;
                stockPanel.buttonList[i].GetComponent<Image>().sprite = sprite;
                return;
            }

        }

    }

    public void PanelToNull(int num)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            if (panels[i] == num)
            {
                Panels[i] = 0;
                stockPanel.buttonList[i].GetComponent<Image>().sprite = null;
                return;
            }
        }
    }

}
