using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CurrentLevel : MonoBehaviour
{
    string name;
    Text levelName;
    void Start()
    {
        levelName = GameObject.Find("LevelName").GetComponent<Text>();
        name = SceneManager.GetActiveScene().name;
        levelName.text = name;
    }
}
