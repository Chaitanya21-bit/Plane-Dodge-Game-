using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public float tapForce = 500;
    public Rigidbody2D player;
    public static int score = 0;
    public Text scoreText;
    public GameObject loseScreen;

    public float minY;
    public float maxY;

    public TextMeshProUGUI tapText;
    public int tapCount = 0;

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
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
        scoreText.text = score.ToString();
        tapText.text = tapCount.ToString();
        if (Input.GetMouseButtonDown(0) || Input.touchCount>0)
        {
            player.AddForce(Vector2.up * tapForce);
            tapCount++;
        }
        //Touch firstTouch = Input.GetTouch(0);
        //if (firstTouch.phase == TouchPhase.Began)
        //{
         //   player.AddForce(Vector2.up * tapForce);
        //}
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
