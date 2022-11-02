using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    private Transform tf;
    private Vector2 initialPos;
    private Vector2 highscore;
    private Rigidbody2D rb;

    public GameObject first, second, third, fourth, fifth, sixth, seventh, eighth;

    //public GameObject checkpoint;

    float initialX, initialY;

    public Text score;

    float volume;
    float bigVol;

    private Vector2 direction;

    bool fit = false, sed = false, thd = false, foh = false, fih = false, sih = false, seh = false, eih = false;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();


        initialX = tf.position.x;
        initialY = tf.position.y;

        initialPos = new Vector2(initialX, initialY);

        highscore = new Vector2(0, 0);


        direction = new Vector2(0.253f, 0.434f);
    }

    // Update is called once per frame
    void Update()
    {

        volume = float.Parse(score.text) ;

        if(volume > 100)
        {
            if (fit == false)
            {
                first.SetActive(true);
                fit = true;
            }
        }
        

        if (volume > 200)
        {
            if (sed == false)
            {
                second.SetActive(true);
                sed = true;
            }
        }
        

        if (volume > 300)
        {
            if (thd == false)
            {
                third.SetActive(true);
                thd = true;
            }
        }
        

        if (volume > 500)
        {
            if (foh == false)
            {
                fourth.SetActive(true);
                foh = true;
            }
        }

        if (volume > 700)
        {
            if (fih == false)
            {
                fifth.SetActive(true);
                fih = true;
            }
        }


        if (volume > 900)
        {
            if (sih == false)
            {
                sixth.SetActive(true);
                sih = true;
            }
        }


        if (volume > 1100)
        {
            if (seh == false)
            {
                seventh.SetActive(true);
                seh = true;
            }
        }


        if (volume > 1400)
        {
            if (eih == false)
            {
                eighth.SetActive(true);
                eih = true;
            }
        }

        if (fit == true || sed == true || thd == true || foh == true || fih == true || sih == true || seh == true || eih == true)
        {
            Invoke("Reset", 1.5f);
        }
        /*
        if (initialPos.x + volume > highscore.x)
        {
            highscore = initialPos + new Vector2(volume, 0);

            Instantiate(checkpoint, highscore, Quaternion.identity);
        }
        */
    }

    private void FixedUpdate()
    {

        //tf.position = initialPos + new Vector2(volume, 0);

        //rb.AddForce(direction * volume *10000);

        //Invoke("Reset", 0.2f);
    }
    private void Reset()
    {
        if (fit == true)
        {
            first.SetActive(false);
            fit = false;
        }
        if (sed == true)
        {
            second.SetActive(false);
            sed = false;
        }
        if (thd == true)
        {
            third.SetActive(false);
            thd = false;
        }
        if (foh == true)
        {
            fourth.SetActive(false);
            foh = false;
        }
        if (fih == true)
        {
            fifth.SetActive(false);
            fih = false;
        }
        if (sih == true)
        {
            sixth.SetActive(false);
            sih = false;
        }
        if (seh == true)
        {
            seventh.SetActive(false);
            seh = false;
        }
        if (eih == true)
        {
            eighth.SetActive(false);
            eih = false;
        }
        //tf.position = initialPos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "rect")
        {
            //collision
        }
    }




    

}
