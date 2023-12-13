using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController7 : MonoBehaviour
{
    public float moveSpeed = 5;
    public float hoInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hoInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * hoInput * moveSpeed * Time.deltaTime);
       
    }
}
