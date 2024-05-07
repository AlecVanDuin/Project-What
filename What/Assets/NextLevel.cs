using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour, IToInteract
{

    public string NaamLevel;
    public void Interact()
    {
        SceneManager.LoadScene(NaamLevel);
    }
}
