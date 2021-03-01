using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    private Vector2 targetPos;
    public float yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 3;
    public Text healthDisplay;
    
    public int points = 0;
    public Text pointsDisplay;

    public GameObject gameOver;
    public GameObject levelComplete;

    public void Update()
    {
        healthDisplay.text = "HP: " + health.ToString();
        pointsDisplay.text = "Food: " + points.ToString() + "/30";

        if (health <= 0){
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
        if (points >= 30){
            levelComplete.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        // controls

        if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight){
            targetPos = new Vector2(transform.position.x, transform.position.y + yincrement);

        }else if(Input.GetKeyDown(KeyCode.DownArrow)&& transform.position.y > minHeight){
            targetPos = new Vector2(transform.position.x, transform.position.y - yincrement);
        
         // dev commands

        }else if (Input.GetKeyDown(KeyCode.H)){
            health = 9999;
        
        }else if (Input.GetKeyDown(KeyCode.N)){
            GetComponent<BoxCollider2D>().enabled = (GetComponent<BoxCollider2D>().enabled) ? false : true;
        }

        
    }
}
