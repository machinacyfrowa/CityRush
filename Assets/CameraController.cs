using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    Vector3 offset;
    Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        targetPosition = player.transform.position + offset;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, 0.1f);
    }
}
