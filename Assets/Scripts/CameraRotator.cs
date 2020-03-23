using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    [SerializeField] private float speed = 0f;
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
