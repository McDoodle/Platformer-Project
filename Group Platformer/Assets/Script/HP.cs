using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour {
    public int lives = 10;
    public GameObject PauseMenu;
    public GameObject deathCanvas;
    public Slider HealthSlider;
    public Slider HealthSlider2;
    public Text healthText;
    public int health = 10;
    float timer = 0.0f;
    public AudioClip soundToPlay;
    void Start()
    {
        Time.timeScale = 1;
        HealthSlider.GetComponent<Slider>().value = health;
        //HealthSlider2.GetComponent<Slider>().value = health;
        healthText.GetComponent<Text>().text = "Health: " + health;
        //PlayerPrefs.SetInt("Lives", lives);
        lives = PlayerPrefs.GetInt("Loves");
    }
    private void Update()
    {
        timer += Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && timer > 1.0)
        {
            timer = 0;
            health -= 5;
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundToPlay);
            healthText.GetComponent<Text>().text = "Health: " + health;
            HealthSlider.GetComponent<Slider>().value = health;
            //HealthSlider2.GetComponent<Slider>().value = health;
        }
        if (health <= 0)
        {
            deathCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        float yVelocity = GetComponent<Rigidbody2D>().velocity.y;
        if (collision.gameObject.tag == "Enemy" && timer > 1.0 && yVelocity >=0)
        {
            timer = 0;
            health -= 2;
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
            if(lives == 0)
            {
                SceneManager.LoadScene( "Lose");
            }
            PlayerPrefs.SetInt("Lives", lives - 1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
