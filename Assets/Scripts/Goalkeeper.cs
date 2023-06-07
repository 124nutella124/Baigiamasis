using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goalkeeper : MonoBehaviour
{
    private bool canRotate = true;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && canRotate)
        {
            float randomRotation = Random.Range(0, 2) == 0 ? 45f : -45f;
            transform.Rotate(0f, 0f, randomRotation);
        }
    }
}
