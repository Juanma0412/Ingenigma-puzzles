using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Move_pieces : MonoBehaviour
{
    public GameObject SelectedPiece;
    int Superpos = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
            if (hit.transform.CompareTag("Puzzle_pieces"))
            {
                if (!hit.transform.GetComponent<Game_script>().Initial_position)
                {
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<Game_script>().Selected = true;
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = Superpos;
                    Superpos++;
                }   
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (SelectedPiece != null)
            {
                SelectedPiece.GetComponent<Game_script>().Selected = false;
                SelectedPiece = null;
            }
            
        }
        if (SelectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
    }
}
