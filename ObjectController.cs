using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public float speed = 20f; private float turnSpeed = 17.5f;
    private float VerticalInput; private float HorizontalInput;

    void Start(){}
    void Update()
    {
        VerticalInput = Input.GetAxis("Vertical"); HorizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * VerticalInput * speed * Time.deltaTime);
        transform.Rotate(Vector3.up, HorizontalInput * turnSpeed * Time.deltaTime);
    }
}