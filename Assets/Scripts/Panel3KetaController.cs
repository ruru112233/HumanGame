using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Debug.Log("³‰ğ");
            gameObject.SetActive(false);
        }
    }

    // ButtonPack‚Ì’l‚ğæ“¾‚µ‚ÄstringŒ^‚Å•Ô‚·
    private string ButtonPackAns()
    {
        string ans = "";

        string s1 = buttonPack1.pwNo.ToString();
        string s2 = buttonPack2.pwNo.ToString();
        string s3 = buttonPack3.pwNo.ToString();

        ans = s1 + s2 + s3;

        return ans;
    }
}
