using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed = 1000f;
    public Vector2 Direction = new Vector2 (0, 1);
    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.AddForce(Direction.normalized * Speed * Time.deltaTime, ForceMode.Impulse);
    }

    // Update is called once per frame
    private void Update()
    {
        if(Mathf.Abs(rigidBody.velocity.y) <= 1)
        {
            rigidBody.velocity += Vector3.up * 5f * (rigidBody.velocity.y >= 0 ? 1 : -1) * Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        rigidBody.velocity = rigidBody.velocity.normalized * Speed * Time.deltaTime;
    }
}
