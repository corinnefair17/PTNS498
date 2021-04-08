using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    private GameObject player;
    private GameObject cam;
    public string sceneName;
    public Vector3 playerPosition;
    public Vector3 camMinPosition;
    public Vector3 camMaxPosition;
    private bool playerAtDoor;

    // Start is called before the first frame update
    void Start()
    {
        playerAtDoor = false;
        player = GameObject.FindWithTag("Player");
        cam = GameObject.FindWithTag("MainCamera");
    }

    void Update() 
    {
        if (playerAtDoor && Input.GetKeyDown(KeyCode.E)) 
        {
            Scene sceneToLoad = SceneManager.GetSceneByName(sceneName);
            SceneManager.MoveGameObjectToScene(player, sceneToLoad);
            SceneManager.MoveGameObjectToScene(cam, sceneToLoad);
            player.transform.position = playerPosition;
            cam.GetComponent<CameraController>().minPosition = camMinPosition;
            cam.GetComponent<CameraController>().maxPosition = camMaxPosition;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            playerAtDoor = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            playerAtDoor = false;
        }
    }
}
