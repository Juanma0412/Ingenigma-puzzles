 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Game_script : MonoBehaviour
{
    private Vector3 Random_position;
    public bool Initial_position;
    public bool Selected;
    // Start is called before the first frame update
    void Start()
    {
        Random_position = transform.position;
        transform.position = new Vector3(Random.Range(6,16),Random.Range(5,-6));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Random_position)<0.5f)
        {
            if (!Selected)
            {
                if (Initial_position == false){
                    transform.position = Random_position;
                    Initial_position = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    GetComponent<BoxCollider2D>().enabled = !GetComponent<BoxCollider2D>().enabled;
                    // Llama al método PiecePlaced en el script "GameOver"
                    GameObject.FindWithTag("MainCamera").GetComponent<Game_over>().PiecePlaced();
                }

            }
        }
    }
}
