using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CheckPoint;

public class PlayerController : MonoBehaviour
{
    private float speed = 2.0f;
    private float angleSpeed = 100;

    private float jumpPower = 6.0f;
    private bool jumpFlag = false;

    

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!FlagManager.playerStop)
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        if (!FlagManager.playerStop)
        {
            PlayerMove();
        }
    }

    private void PlayerMove()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // 前
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            float newSpeed = speed / 3;

            // 後
            transform.position -= transform.forward * newSpeed * Time.deltaTime;
        }

        // 左右に向く
        float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * angleSpeed;
        transform.Rotate(Vector3.up * x);

    }

    private void Jump()
    {
        if (jumpFlag) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpFlag = true;
            // ジャンプ
            rb.AddForce(transform.up * jumpPower, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpFlag = false;
        }
    }
}
