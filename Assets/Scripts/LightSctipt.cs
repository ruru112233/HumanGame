using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CheckPoint;

public class LightSctipt : MonoBehaviour
{

    [SerializeField]
    private GameObject lightObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (FlagManager.dengenOff)
        {
            lightObj.SetActive(false);
        }
        else
        {
            lightObj.SetActive(true);
        }
    }
}
