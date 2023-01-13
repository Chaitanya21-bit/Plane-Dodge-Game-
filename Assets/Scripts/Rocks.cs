using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocks : MonoBehaviour

{
    public float speed = 5f;
    public int lifetime = 5;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyThis", lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    void DestroyThis()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            Player.score++;
            Debug.Log("one");
        }
        
    }
}
