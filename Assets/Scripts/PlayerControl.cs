using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public AudioClip gold, fall;
    public GameControl gameControl;
    private float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameControl.gameActive)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            x = x * Time.deltaTime * speed;
            y = y * Time.deltaTime * speed;
            transform.Translate(x, 0f, y);
        }

        

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Gold"))
        {
            AudioSource.PlayClipAtPoint(gold, transform.position);
            gameControl.GoldUp();
            Destroy(collision.gameObject);

        }else if (collision.gameObject.tag.Equals("Enemy"))
        {
            AudioSource.PlayClipAtPoint(fall, transform.position);

            gameControl.gameActive = false;
        }
    }
}
