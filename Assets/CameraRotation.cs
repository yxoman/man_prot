using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    private Vector3 startMousePosition;

    private Transform mainCamera;

    void Start()
    {
        mainCamera = Camera.main.transform;
    }

    void Update()
    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            startMousePosition = Input.mousePosition;
//        }
//
//        if (Input.GetMouseButton(0))
//        {
//            if (Vector3.Distance(Input.mousePosition, startMousePosition) > 1f)
//                camera.up = Input.mousePosition - startMousePosition;
//
//            camera.eulerAngles = new Vector3(0f, -90f, camera.eulerAngles.z);
//        }
    }
}