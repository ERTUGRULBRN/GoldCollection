using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public bool gameActive = true;
    public int goldPiece = 0;
    public UnityEngine.UI.Text goldPieceText;
    public UnityEngine.UI.Button startButton;
    void Start()
    {
        GetComponent<AudioSource>().Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoldUp()
    {
        goldPiece += 1;
        goldPieceText.text = "" + goldPiece;
    }
    public void GameStart()
    {
        gameActive = true;
        startButton.gameObject.SetActive(false);
    }
}
