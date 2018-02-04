using UnityEngine;

public class GravityController : MonoBehaviour
{
    private Transform mainCamera;

    void Start()
    {
        mainCamera = Camera.main.transform;
    }

    void Update()
    {
        Physics.gravity = -mainCamera.transform.up * 10f;
    }
}