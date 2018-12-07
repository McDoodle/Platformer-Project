using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour {
    public int lives = 3;
    public Text livesText;
    public GameObject PauseMenu;
    public GameObject deathCanvas;
    public Slider HealthSlider;
    public Slider HealthSlider2;
    public Text healthText;
    public int health = 2;
    float timer = 0.0f;
    public AudioClip soundToPlay;
    void Start()
    {
        Time.timeScale = 1;
        //HealthSlider.GetComponent<Slider>().value = health;
        //HealthSlider2.GetComponent<Slider>().value = health;
        healthText.GetComponent<Text>().text = "Armor: " + health;
        livesText.GetComponent<Text>().text = "Lives: " + lives;
        //PlayerPrefs.SetInt("Lives", lives);
        lives = PlayerPrefs.GetInt("Lives");
    }
    private void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(GetComponent<Rigidbody2D>().velocity);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        float yVelocity = GetComponent<Rigidbody2D>().velocity.y;
        if (collision.gameObject.tag == "Enemy" && timer > 1.0 && yVelocity >= 0)
        {
            timer = 0;
            health -= 1;
            //Camera.main.GetComponent<AudioSource>().PlayOneShot(soundToPlay);
            healthText.GetComponent<Text>().text = "Armor: " + health;
            //HealthSlider.GetComponent<Slider>().value = health;
            //HealthSlider2.GetComponent<Slider>().value = health;

        }
        
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        float yVelocity = GetComponent<Rigidbody2D>().velocity.y;
        if (collision.gameObject.tag == "Enemy" && timer > 1.0 && yVelocity >=0)
        {
            timer = 0;
            health -= 1;
            //healthText.GetComponent<Text>().text = "Health: " + health;
            HealthSlider.GetComponent<Slider>().value = health;
            //HealthSlider2.GetComponent<Slider>().value = health;
        }
        if (collision.gameObject.tag == "water")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        if (health <= 0)
        {
            if(lives <= 0)
            {
                SceneManager.LoadScene("Lose");
            }
            PlayerPrefs.SetInt("Lives", lives - 1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
