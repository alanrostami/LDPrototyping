using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float runSpeed;
    public float horizontalInput;
    public float jumpHeight;
    public float jumpInput;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        jumpInput = Input.GetAxis("Jump");

        transform.Translate(Vector3.forward * Time.deltaTime * runSpeed * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * jumpHeight * jumpInput);
    }
}
