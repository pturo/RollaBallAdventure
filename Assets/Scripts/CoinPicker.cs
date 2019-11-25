using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPicker : MonoBehaviour
{
    public Text countText;
    public GameObject particles;
    private int count;

    void Start()
    {
        SetCountText();
        count = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Instantiate(particles, transform.position, Quaternion.identity);
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Coins: " + count.ToString();
    }
}
