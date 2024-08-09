using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowInteration : MonoBehaviour
{
    public Transform player;
    public float interactionDistance = 1.5f;
    public KeyCode interactionKey = KeyCode.E;
   
    [SerializeField] 
    private string sceneName;
    
    void Update()
    {
        // calculate distance between player and arrow
        float distance = Vector3.Distance(player.position, transform.position);

        // if close enough, change scene when press E
        if(distance <= interactionDistance )
        {
            //Debug.Log("Close Enough to Interact");
            if (Input.GetKeyDown(interactionKey))
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
