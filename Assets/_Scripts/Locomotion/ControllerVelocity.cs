using UnityEngine;
using UnityEngine.InputSystem;

/*
 * Credits to VR with Andrew for help on velocity script.
 * https://www.youtube.com/watch?v=i6lltmrE9V8&t=3s
 */
namespace Locomotion
{
    public class ControllerVelocity : MonoBehaviour
    {
        [SerializeField] private InputActionProperty velocityProperty;

        public Vector3 Velocity { get; private set; } = Vector3.zero;

        private void Update()
        {
            Velocity = velocityProperty.action.ReadValue<Vector3>();
        }
    }

}

