using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameControl gameControl;
    float camSensibiliy = 5f;
    float camSoftness = 2f;
    Vector2 transPos;
    Vector2 camPos;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = transform.parent.gameObject;
        camPos.y = 12f;
        
    }

    // Update is called once per frame
    void Update()
    {  if (gameControl.gameActive)
        {
            Vector2 mousePos = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            mousePos = Vector2.Scale(mousePos, new Vector2(camSensibiliy * camSoftness, camSensibiliy * camSoftness));
            transPos.x = Mathf.Lerp(transPos.x, mousePos.x, 1f / camSoftness);
            transPos.y = Mathf.Lerp(transPos.y, mousePos.y, 1f / camSoftness);
            camPos = camPos + transPos;
            transform.localRotation = Quaternion.AngleAxis(camPos.y, Vector3.right);
            player.transform.localRotation = Quaternion.AngleAxis(camPos.x, player.transform.up);
        }
        


    }
}
