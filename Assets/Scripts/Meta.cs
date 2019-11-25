using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            SceneManager.LoadScene("WinScene", LoadSceneMode.Single);
        }
    }
}
