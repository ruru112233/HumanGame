using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonPack : MonoBehaviour
{
    public Button upButton;
    public Button downButton;

    public Text noText;

    private int pwNo = 0;

    public int PwNo
    {
        get { return pwNo; }
        set { pwNo = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        noText.text = pwNo.ToString();

        upButton.onClick.AddListener(() =>
        {
            pwNo++;

            if (pwNo > 9)
            {
                pwNo = 0;
            }

            noText.text = pwNo.ToString();

        });

        downButton.onClick.AddListener(() =>
        {
            pwNo--;

            if (pwNo < 0)
            {
                pwNo = 9;
            }

            noText.text = pwNo.ToString();
        }); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
