using UnityEngine;

public class Fish : MonoBehaviour
{
    GameLogic gameLogic;
    private const string TAGPLAYER = "Player";
    private const string TAGFLOOR = "Fish";

    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameLogic>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == TAGPLAYER && gameObject.tag == "Fish")
        {
            gameLogic.AddScore();
            Debug.Log("added score");
            Destroy(this.gameObject);
        }

        //private void OnTriggerEnter2D(Collider2D col)
        //{

        //    if (col.CompareTag("Player"))
        //    {
        //        if (gameLogic != null)
        //        {
        //            gameLogic.AddFish();
        //            Destroy(this.gameObject);
        //            Debug.Log("Gamelogic!=null");
        //        }
        //        else
        //        {
        //            Debug.Log("Gamelogic=null");
        //        }

        //        Debug.Log("playercollision");
        //    }
        //    else if (col.CompareTag("Floor"))
        //    {
        //        if (gameLogic == null)
        //        {
        //            Debug.Log("Gamelogic=null22");
        //            return;
        //        }

        //        Destroy(this.gameObject);
        //        Debug.Log("groundcollision");
        //    }
        }
    }