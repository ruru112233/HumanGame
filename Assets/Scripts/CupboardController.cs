using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KeyCodeScript;

public class CupboardController : MonoBehaviour
{

    private bool investigateFlag = false;

    public Transform board1, board2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = 270 - transform.localEulerAngles.y;

        if (investigateFlag)
        {
            if (Input.GetKeyDown(KeySet.investigateKey))
            {
                if (transform.localEulerAngles.y == 0)
                {
                    board1.rotation = Quaternion.Euler(0, 270, 0);
                    board2.rotation = Quaternion.Euler(0, -270, 0);
                }
                else if (transform.localEulerAngles.y == 90)
                {
                    board1.rotation = Quaternion.Euler(0, 0, 0);
                    board2.rotation = Quaternion.Euler(0, -180, 0);
                }
                else if (transform.localEulerAngles.y == 180)
                {
                    board1.rotation = Quaternion.Euler(0, -270, 0);
                    board2.rotation = Quaternion.Euler(0, 270, 0);
                }
                else if (transform.localEulerAngles.y == 270)
                {
                    board1.rotation = Quaternion.Euler(0, -180, 0);
                    board2.rotation = Quaternion.Euler(0, 0, 0);
                }

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
