using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    public VariableJoystick variableJoystick;
    public float moveSpeed = 5f;
    public void Update()
    {
        Vector3 direction = Vector3.right * variableJoystick.Horizontal;
        transform.position += direction * moveSpeed * Time.deltaTime;
    }

}
