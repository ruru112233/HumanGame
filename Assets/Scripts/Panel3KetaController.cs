using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CheckPoint;

public class Panel3KetaController : MonoBehaviour
{
    [SerializeField]
    private ButtonPack buttonPack1, buttonPack2, buttonPack3;

    private string q2Ans = "739";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (q2Ans.Equals(ButtonPackAns()))
        {
            Debug.Log("ê≥â");
            FlagManager.playerStop = false;
            gameObject.SetActive(false);
        }
    }

    public void PwInit()
    {
        buttonPack1.PwNo = 0;
        buttonPack1.noText.text = buttonPack1.PwNo.ToString();
        buttonPack2.PwNo = 0;
        buttonPack2.noText.text = buttonPack2.PwNo.ToString();
        buttonPack3.PwNo = 0;
        buttonPack3.noText.text = buttonPack3.PwNo.ToString();
    }

    // ButtonPackÇÃílÇéÊìæÇµÇƒstringå^Ç≈ï‘Ç∑
    private string ButtonPackAns()
    {
        string ans = "";

        string s1 = buttonPack1.PwNo.ToString();
        string s2 = buttonPack2.PwNo.ToString();
        string s3 = buttonPack3.PwNo.ToString();

        ans = s1 + s2 + s3;

        return ans;
    }
}
