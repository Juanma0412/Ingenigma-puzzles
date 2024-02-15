using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_script : MonoBehaviour
{
    public int numeroEscena;

    public void CambioEscena()
    {
        SceneManager.LoadScene(numeroEscena);
    }

}
