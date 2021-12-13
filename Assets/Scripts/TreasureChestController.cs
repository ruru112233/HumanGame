using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KeyCodeScript;
using CheckPoint;

public class TreasureChestController : MonoBehaviour
{

    private bool investigateFlag = false;

    [SerializeField]
    private GameObject upper;
    // Start is called before the first frame update
    void Start()
    {
        FlagManager.treasureFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (investigateFlag && Input.GetKeyDown(KeySet.investigateKey))
        {
            if (FlagManager.treasureFlag)
            {
                Debug.Log("•ó” ‚ğŠJ‚¯‚½");
                upper.transform.rotation = Quaternion.Euler(-170, -90,0);
            }
            else
            {
                Debug.Log("•ó” ‚É‚ÍƒJƒM‚ª‚©‚©‚Á‚Ä‚¢‚éB");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            investigateFlag = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            investigateFlag = false;
        }
    }
}
