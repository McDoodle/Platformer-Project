using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStomp : MonoBehaviour {
    public GameObject prefab;
    void OnCollisionEnter2D(Collision2D collision)
    {
        float yVelocity = collision.gameObject.GetComponent<Rigidbody2D>().velocity.y;
        if (collision.gameObject.tag == "player" && yVelocity < 0)
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 6));
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
	
}
