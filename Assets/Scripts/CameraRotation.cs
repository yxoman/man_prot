using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    private Vector3 startMousePosition;

    private Transform mainCamera;


    void Start()
    {
        mainCamera = Camera.main.transform.parent;
    }

    void Update()
    {
//        mainCamera.forward = gravityJoystick.Axis;
//        mainCamera.eulerAngles = new Vector3(mainCamera.eulerAngles.x, 0f, 0f);
//        if (Input.GetMouseButtonDown(0))
//        {
//            startMousePosition = Input.mousePosition;
//        }
//
//        if (Input.GetMouseButton(0))
//        {
//            if (Vector3.Distance(Input.mousePosition, startMousePosition) > 1f)
//                
//
        mainCamera.up = -Physics.gravity;
//        mainCamera.eulerAngles = new Vector3(0f, -90f, mainCamera.eulerAngles.z);
//        }
    }
}