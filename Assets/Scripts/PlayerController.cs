using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody physic;
    public int speed;
    public float xMin, xMax, zMin, zMax;
     void Start()
    {
        physic = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        physic.velocity = movement*speed;

        Vector3 position = new Vector3(
            Mathf.Clamp(physic.position.x, xMin, xMax),
            1,
            Mathf.Clamp(physic.position.z, zMin, zMax)
            );

        physic.position = position;
    }
}
