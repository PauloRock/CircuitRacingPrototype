using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehavior : MonoBehaviour
{
    public float speedForce = 5.257f;
    public bool isKeyPressed = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
            isKeyPressed = true;
        } else {
            isKeyPressed = false;
        }
        if (isKeyPressed){
            transform.Translate(Vector3.left * Time.deltaTime * speedForce);
        }
    }
}
