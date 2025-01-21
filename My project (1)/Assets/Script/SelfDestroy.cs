using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    public string Name = "";

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == Name)
        {
            Object.Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
