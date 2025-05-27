using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class BasePlayer : MonoBehaviour
{
    public Transform spawnPointCenter;

    [Header("Assign one or more bullet prefabs here")]
    public GameObject[] bullets;
    public float Bulletspeed = 5f;

    void Update()
    {
        if (!GameManager.Instance.GameState)
            return;

        // Mouse input
        if (Input.GetMouseButtonDown(0))
        {
          
        }

        // Touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                
            }
        }
    }

   

  

   
    public void GameOver()
    {
        // GameManager.Instance.GameOVer();
    }

    public void Reset()
    {

    }
}
