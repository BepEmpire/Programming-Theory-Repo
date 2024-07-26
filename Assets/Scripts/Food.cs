using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Food : MonoBehaviour
{
    [SerializeField] private float force = 10.0f;
    protected Rigidbody objectRb;
    [SerializeField] private int score;
    public int Score { get { return score; } private set { score = value; } }

    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
        objectRb.AddForce(Vector3.down * force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        Action();
    }

    protected abstract void Action();

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
