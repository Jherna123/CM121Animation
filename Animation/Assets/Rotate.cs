using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float Speed = 5f;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Capsule")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Speed, 0, 0);
    }

}
