using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnifyingObject : MonoBehaviour
{
    Renderer _renderer;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();    
        cam = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ScreenPos = cam.WorldToScreenPoint(transform.position);
        ScreenPos.x = ScreenPos.x / Screen.width;
        ScreenPos.y = ScreenPos.y / Screen.height;
        _renderer.material.SetVector("_ZoomPosition", ScreenPos);
    }
}
