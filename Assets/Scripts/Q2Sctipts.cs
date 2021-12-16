using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KeyCodeScript;
using CheckPoint;

public class Q2Sctipts : MonoBehaviour
{
    private bool investigateFlag = false;
    [SerializeField]
    private GameObject Q2Panel;

    private Panel3KetaController panel3keta;

    // Start is called before the first frame update
    void Start()
    {
        panel3keta = Q2Panel.GetComponent<Panel3KetaController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (investigateFlag)
        {
            if (Input.GetKeyDown(KeySet.investigateKey))
            {
                Debug.Log("3���̔ԍ�������");
                FlagManager.playerStop = true;
                Q2Panel.SetActive(true);
            }
            else if (Input.GetKeyDown(KeySet.chancelKey))
            {
                // �L�����Z��
                FlagManager.playerStop = false;
                panel3keta.PwInit();
                Q2Panel.SetActive(false);
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("�ڐG");
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
