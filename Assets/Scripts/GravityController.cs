using UnityEngine;

public class GravityController : MonoBehaviour
{
    private Transform mainCamera;
    private GravityJoystick gravityJoystick;

    void Start()
    {
        mainCamera = Camera.main.transform;
        gravityJoystick = FindObjectOfType<GravityJoystick>();
    }

    void Update()
    {
        Physics.gravity = new Vector3(0f, gravityJoystick.Axis.y, gravityJoystick.Axis.x) * 10f;
    }
}