using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartImage : MonoBehaviour
{
    public GameObject ImageHint;
    public Vector3 SizeHint = new Vector3(1.111956f, 1.771049f, 1f);
    void Start()
    {
        List_images.Instance.SetPuzzle();
        List_images.Instance.SetHint();
        ImageHint.SetActive(false);
        ImageHint.transform.localScale = SizeHint;

    }
}
