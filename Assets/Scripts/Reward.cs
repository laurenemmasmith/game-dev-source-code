using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    public int reward;
    private float speed;
    public float speedMultiplier;

    public GameObject effect;
    public Shake shake;
    public GameObject spawner;

    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ShakeCam").GetComponent<Shake>();
        spawner = GameObject.FindGameObjectWithTag("Spawner");
        speed = Random.Range(5f, 11f)*speedMultiplier;
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            shake.CamShake();
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponent<Player>().points += reward;
            Destroy(gameObject);
        }
    }
}