using System;
using UnityEngine;

public class CellMovement : MonoBehaviour
{
    // [Header("Values")]
    // [SerializeField] private float swimForce = 2f;
    // [SerializeField] private float dragForce = 1f;

    // [Header("References")]
    // [SerializeField] private Transform trackingReference;
    
    // private Rigidbody _rigidbody;
    // private Quaternion _rotation;
    private float _speed = 0f;
    // private Vector3 _velocity = new Vector3(0, 0, 0);

    // private void Awake()
    // {
    //     _rigidbody = GetComponent<Rigidbody>();
    //     _rigidbody.useGravity = false;
    // }

    private void FixedUpdate()
    {
        // transform.Translate(Vector3.forward * _speed);
        // Quaternion.RotateTowards(transform.rotation, _rotation, 1);
        var normalizedBPM = NormalizeBPM(ReadPort.Instance.GetBPM());
        if (normalizedBPM == 0)
        {
            normalizedBPM = 1;
        }
        transform.Translate (Vector3.forward * (_speed * normalizedBPM), Space.World);
        transform.Rotate (Vector3.down * -2);
        transform.Rotate (Vector3.back * 1);
        transform.Rotate (Vector3.left * 3);

        // Vector3 worldVelocity = trackingReference.TransformDirection(velocity);
        // _rigidbody.AddForce(_velocity * swimForce, ForceMode.Acceleration);

        // slow down after cell move forward
        // if (_rigidbody.velocity.sqrMagnitude > 0.01f)
        // {
        //     _rigidbody.AddForce(-_rigidbody.velocity * dragForce, ForceMode.Acceleration);
        // }
    }

    // public void SetVelocity(Vector3 vector)
    // {
    //     _velocity = vector;
    // }
    
    public void SetSpeed(float speed)
    {
        _speed = speed;
    }
    
    // public void SetRotation(Quaternion rotation)
    // {
    //     _rotation = rotation;
    // }

    private float NormalizeBPM(int BPM)
    {
        return (float)(Math.Sqrt(BPM / 40f));
    }
}
