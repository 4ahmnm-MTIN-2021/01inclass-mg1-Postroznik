using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour
{
    private SceneLoader sceneLoader;
    public TextMeshProUGUI Score;
    public int scoreAmount;
    public GameObject player;

    void Start()
    {
        sceneLoader = GameObject.FindGameObjectWithTag("Manager").GetComponent<SceneLoader>(); //definiere Sceneloader Script den ich brauche
    }

    void Update()
    {
        //Score.text = scoreAmount.ToString();
    }

    //public void DecreaseTomatos()
    //{
    //    tomatoAmount--;
    //    if (tomatoAmount == 0)
    //    {
    //        PlayerPrefs.SetInt("coinAmount", coinAmount);
    //        sceneLoader.SwitchToScene("GameOver");
    //    }
    //}

    public void AddScore()
    {
        scoreAmount++;
    }
}