using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteManager : MonoBehaviour
{
    public List<Sprite> sprites;

    private int[] panels = new int[] { 1, 0, 0, 0 };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (int panel in panels)
        {
            if (panel == 0)
            {
                return;
            }

            if (panel == 1)
            {
                GameManager.instance.stockPanel.buttonList[panel - 1].GetComponent<Image>().sprite = sprites[0];
            }
        }
    }
}
