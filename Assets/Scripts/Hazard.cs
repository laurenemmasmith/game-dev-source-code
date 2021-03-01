using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public int damage = 1;

    public float baseSpeed;
    public float speed;
    

    public GameObject effect;
    public Shake shake;

    public GameObject spawner;

    void Start(){
        shake = GameObject.FindGameObjectWithTag("ShakeCam").GetComponent<Shake>();
        spawner = GameObject.FindGameObjectWithTag("Spawner");
        speed = Random.Range(3f, 15f);
    }

    private void Update(){
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player")){
            shake.CamShake();
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponent<Player>().health -= damage;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }
    }
}
