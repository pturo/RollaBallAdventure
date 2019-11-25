using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    private Rigidbody rigidbody;

    void Update()
    {
        rigidbody = player.GetComponent<Rigidbody>();

        Vector3 vector = new Vector3(0, 2f, -2f);
        float velocity = rigidbody.velocity.sqrMagnitude;
        vector = vector * (1f+velocity/25f);

        Vector3 newPos = player.position + vector;

        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime*2f);
        transform.LookAt(player);
    }
}
