using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;

    public Text healthText;
    public Text dieText;

    public int health = 10;

    public GameObject scoreKeeper;

    // Start is called before the first frame update
    void Start()
    {
        UpdateHealthText();
    }

    // Update is called once per frame
    void Update()
    {

        if (health > 0)
        {
            float horizontalInput = Input.GetAxis("Horizontal");


            if (horizontalInput < 0)
            {
                transform.localScale = new Vector2(-0.6f, 0.6f);
            }
            else
            {
                transform.localScale = new Vector2(0.6f, 0.6f);
            }

            float verticalInput = Input.GetAxis("Vertical");

            transform.Translate(new Vector2(horizontalInput, verticalInput) * speed);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        DecreaseHealth();
    }

    void DecreaseHealth()
    {

        if (health > 0)
        {
            health--;
            UpdateHealthText();
        }

        if (health <= 0)
        {
            Die();
        }
    }

    void UpdateHealthText()
    {
        healthText.text = "HEALTH: " + health;

    }


    void Die()
    {
        scoreKeeper.GetComponent<ScoreKeeper>().PlayerHasDied();
        dieText.transform.gameObject.SetActive(true);
    }

}
