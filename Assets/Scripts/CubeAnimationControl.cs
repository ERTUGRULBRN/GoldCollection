using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimationControl : MonoBehaviour
{
    float counter = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;
        if (counter < 0)
        {
            GetComponent<Animator>().Play(0);
            counter = Random.Range(4, 6);

        }
    }
}
