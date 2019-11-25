using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {         
            SceneManager.LoadScene("LoseScene", LoadSceneMode.Single);
        }
    }
}
