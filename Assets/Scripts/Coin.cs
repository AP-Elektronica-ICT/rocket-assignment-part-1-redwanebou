using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){ }

    void Update() { }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            var ScoreboardScore = GameObject.FindGameObjectWithTag("Scoreboard").GetComponent<Text>();

            ScoreboardScore.text = (int.Parse(ScoreboardScore.text) + 1).ToString();

            Destroy(gameObject);
        }
    }
}
