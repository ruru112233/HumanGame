using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KeyCodeScript;

public class Q2Sctipts : MonoBehaviour
{
    private bool investigateFlag = false;
    [SerializeField]
    private GameObject Q2Panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (investigateFlag)
        {
            if (Input.GetKeyDown(KeySet.investigateKey))
            {
                Debug.Log("3åÖÇÃî‘çÜÇì¸ÇÍÇÈ");
                Q2Panel.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("ê⁄êG");
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
