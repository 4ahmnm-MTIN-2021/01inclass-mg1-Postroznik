using UnityEngine;
using TMPro;

public class Fish : MonoBehaviour
{
    private const string TAGPLAYER = "Player";
    private const string TAGFLOOR = "Fish";
    public TextMeshProUGUI Score;
    public int scoreAmount;

    void Start()
    {
        scoreAmount = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == TAGPLAYER && gameObject.tag == "Fish")
        {
            scoreAmount++;
            Score.text = scoreAmount.ToString("");
            Destroy(this.gameObject);
        }
    }
 }