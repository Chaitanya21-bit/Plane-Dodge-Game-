using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float tapForce = 500;
    public Rigidbody2D player;
    public static int score = 0;
    public Text scoreText;
    public GameObject loseScreen;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        score = 0;
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        if (Input.GetMouseButton(0))
        {
            player.AddForce(Vector2.up * tapForce);
        }
    }
    public void SetGameTimeScale(float newScale)
    {
        Time.timeScale = newScale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Rocks")
        {
            Time.timeScale = 0;
            loseScreen.SetActive(true);
            Debug.Log("Lost");
        }

    }
}
