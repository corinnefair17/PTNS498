using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 0, -1);

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(
            player.transform.position.x + offset.x,
            player.transform.position.y + offset.y,
            player.transform.position.z + offset.z
        );
    }
}