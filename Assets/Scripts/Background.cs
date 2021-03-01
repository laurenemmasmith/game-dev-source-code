using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed;
    public float endX;
    public float startX;

    public GameObject spawner;
    public float parallaxSpeed;

    private void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner");
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
        speed = spawner.GetComponent<Spawner>().startSpawnGap*parallaxSpeed;
    }
}
