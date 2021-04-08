using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 0, -1);
    public float smoothing;

    public Vector2 minPosition;
    public Vector2 maxPosition;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(
            player.transform.position.x + offset.x,
            player.transform.position.y + offset.y,
            player.transform.position.z + offset.z
        );

        targetPosition.x = Mathf.Clamp(player.transform.position.x, minPosition.x, maxPosition.x);
        targetPosition.y = Mathf.Clamp(player.transform.position.y, minPosition.y, maxPosition.y);

        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
    }
}