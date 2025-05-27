using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            GameManager.Instance.AddScore();
           // GameManager.Instance.Tap.Play();
           // GameManager.Instance.IncreaseSliderValue(0.3f);
            Vector2 spawnPos = collision.ClosestPoint(transform.position);
           // GameManager.Instance.SpawnSlimeAt(spawnPos);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("went");
            GameManager.Instance.GameOver();
        }
    }


   
}
