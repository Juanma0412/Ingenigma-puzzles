using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveMe_hint : MonoBehaviour
{
    public GameObject ImageHint;

    public void Hint()
    {
        ImageHint.SetActive(true);
        Invoke("HideObject", 6f);
    }
    private void HideObject()
    {
        ImageHint.SetActive(false);
    }
}
