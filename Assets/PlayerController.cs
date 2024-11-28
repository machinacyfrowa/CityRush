using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Vector2 inputVector;
    Rigidbody rb;
    [SerializeField]
    public float acceleration = 10;
    [SerializeField]
    public float maneuverability = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        rb.AddForce(acceleration * inputVector.y * transform.forward);
        //rb.AddTorque(maneuverability * rb.velocity.magnitude * inputVector.x * transform.up);
        rb.AddTorque(maneuverability * inputVector.x * transform.up);
    }

    void OnMove(InputValue value)
    {
        inputVector = value.Get<Vector2>();
    }
}
