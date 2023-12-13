using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public int Lives = 3;
    public Image [] LivesUI;
    public GameObject explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Lives -=1;
            for(int i = 0; i < LivesUI.Length; i++)
            {
                if(i < Lives)
                {
                    LivesUI[i].enabled = true;
                }
                else
                {
                    LivesUI[i].enabled = false;
                }
            }
            if (Lives <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy Curse")
        {
            Destroy(collision.gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Lives -= 1;
            for (int i = 0; i < LivesUI.Length; i++)
            {
                if (i < Lives)
                {
                    LivesUI[i].enabled = true;
                }
                else
                {
                    LivesUI[i].enabled = false;
                }
            }
            if (Lives <= 0)
            {
                Destroy(gameObject);
            }
        }

    }
}
