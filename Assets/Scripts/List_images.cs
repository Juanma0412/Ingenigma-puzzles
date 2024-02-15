using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class List_images : MonoBehaviour
{
#region Singleton

public static List_images Instance;

private void Awake(){
    if(Instance != null){
        if(Instance != this){
            Destroy(gameObject);
        }
        return;
    }
    Instance = this;
    DontDestroyOnLoad(this.gameObject);
}

#endregion


   public Sprite[] listSprites;
   public int indiceList = 0;

   public void SetPuzzle()
    {
        GameObject[] pieces = GameObject.FindGameObjectsWithTag("Images_pieces");

        foreach (GameObject Images_pieces in pieces)
        {
            SpriteRenderer imagePiece = Images_pieces.GetComponentInChildren<SpriteRenderer>();

            imagePiece.sprite = listSprites[indiceList];
        }
    }
    public void SetHint()
    {
        GameObject imageHint = GameObject.Find("Jigsaw_imageHint");
        SpriteRenderer hint = imageHint.GetComponent<SpriteRenderer>();
        hint.sprite = listSprites[indiceList];
         
    }
}
