using UnityEngine;
using UnityEngine.InputSystem;

/*
 * Credits to Justin P. Barnett video for help on swimming script
 * https://www.youtube.com/watch?v=ViQzKZvYdgE
 */
namespace Locomotion
{
    [RequireComponent(typeof(Rigidbody))]
    public class Swimmer : MonoBehaviour
    {
        [Header("Values")]
        [SerializeField] private float swimForce = 2f;
        [SerializeField] private float dragForce = 1f;
        [SerializeField] private float minForce;
        [SerializeField] private float minTimeBetweenStrokes;
        
        [Header("References")]
        [SerializeField] private InputActionReference leftControllerSwimReference;
        [SerializeField] private ControllerVelocity leftHandControllerVelocity;
        [SerializeField] private InputActionReference rightControllerSwimReference;
        [SerializeField] private ControllerVelocity rightHandControllerVelocity;
        [SerializeField] private Transform trackingReference;

        private Rigidbody _rigidbody;
        private float _cooldownTimer;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _rigidbody.useGravity = false;
            _rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        }

        private void FixedUpdate()
        {
            _cooldownTimer += Time.fixedDeltaTime;
            
            if (SwimmingButtonsPressed())
            {
                // gets velocity of where to move
                var leftHandVelocity = leftHandControllerVelocity.Velocity;
                var rightHandVelocity = rightHandControllerVelocity.Velocity;
                
                Vector3 localVelocity = leftHandVelocity + rightHandVelocity;
                
                
                // reverse control to swim forward when pushing backwards
                localVelocity *= -1;
                
                // sqrMagnitude just faster
                if (localVelocity.sqrMagnitude > minForce * minForce)
                {
                    // add force to move forward
                    Vector3 worldVelocity = trackingReference.TransformDirection((localVelocity));
                    _rigidbody.AddForce(worldVelocity * swimForce, ForceMode.Acceleration);
                    _cooldownTimer = 0f;
                }
            }
            
            // slow down after you move forward
            if (_rigidbody.velocity.sqrMagnitude > 0.01f)
            {
                _rigidbody.AddForce(-_rigidbody.velocity * dragForce, ForceMode.Acceleration);
            }
        }

        private bool SwimmingButtonsPressed()
        {
            return _cooldownTimer > minTimeBetweenStrokes
                    && leftControllerSwimReference.action.IsPressed()
                    && rightControllerSwimReference.action.IsPressed();
        }
    }
}


