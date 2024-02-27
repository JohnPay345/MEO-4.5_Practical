using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    [SerializeField] public float speed = 5;

    void Update() {
        float movement = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;
    }
}
