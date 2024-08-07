using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMotionTracker : MonoBehaviour
{
    Camera camera;
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    void Update()
    {
        Debug.Log(GetMouseX());
    }

    private float GetMouseX()
    {
        Vector3 mousePoint = Input.mousePosition;                                                  
        mousePoint.z = camera.WorldToScreenPoint(gameObject.transform.position).z;
        return camera.ScreenToWorldPoint(mousePoint).x;
    }
}
