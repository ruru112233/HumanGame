using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteManager : MonoBehaviour
{
    public List<Sprite> sprites;

    private int[] panels = new int[] { 0, 0, 0, 0 };

    [SerializeField]
    private GameObject getItemPanel;

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
                StartCoroutine(GetItemView(keyNo));
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

    string ItemName(int itemNo)
    {
        string itemName = "";

        string tmp = "����ɓ��ꂽ!";

        switch (itemNo)
        {
            case 0:
                itemName = "�J�M�i���j" + tmp;
                break;
            case 1:
                itemName = "�J�M�i�j" + tmp;
                break;
            case 2:
                itemName = "�J�M�i�΁j" + tmp;
                break;
            case 3:
                itemName = "�J�M�i�ԁj" + tmp;
                break;
        }

        return itemName;
    }

    IEnumerator GetItemView(int keyNo)
    {
        getItemPanel.SetActive(true);
        getItemPanel.transform.GetChild(0).GetComponent<Text>().text = ItemName(keyNo - 1);
        yield return new WaitForSeconds(1.0f);

        getItemPanel.SetActive(false);
    }

}
