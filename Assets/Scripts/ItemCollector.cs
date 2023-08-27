using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{   
    [SerializeField] Text coinsText;
    [SerializeField] AudioSource coinSound;
    int coins = 0;
    private void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.CompareTag("Coin"))
        {
            Destroy(collider.gameObject);
            coinSound.Play();
            coins++;
            coinsText.text = "Coins: " + coins;
            
        }
    }
}
