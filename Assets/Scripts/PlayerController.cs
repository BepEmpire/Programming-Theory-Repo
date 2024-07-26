using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float xBoundLeft = -8.0f;
    [SerializeField] private float xBoundRight = 12.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ConstrainPlayerPos();
    }
    void MovePlayer()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);
    }
    void ConstrainPlayerPos()
    {
        if (transform.position.x < xBoundLeft)
        {
            transform.position = new Vector3(xBoundLeft, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xBoundRight)
        {
            transform.position = new Vector3(xBoundRight, transform.position.y, transform.position.z);
        }
    }

}
