using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField]
    float MovementSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("horizontal"));
        rigidbody.MovePosition(transform.position + movement * Time.deltaTime * 5); 

    }
}
