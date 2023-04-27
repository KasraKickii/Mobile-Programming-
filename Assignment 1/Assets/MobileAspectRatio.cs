using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileAspectRatio : MonoBehaviour
{
    public float aspectRatio = 9f / 16f;
    private void Start()
    {
        float currentAspectRatio = (float)Screen.width / (float)Screen.height;
        if (currentAspectRatio < aspectRatio)
        {
            Camera.main.orthographicSize *=aspectRatio / currentAspectRatio;
        }
    }
 
}
