using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_hide : MonoBehaviour
{
    public GameObject MessageLeave;
    // Start is called before the first frame update
    public void Show()
    {
        MessageLeave.SetActive(true);
    }

    // Update is called once per frame
    public void Hide()
    {
        MessageLeave.SetActive(false);
    }
}
