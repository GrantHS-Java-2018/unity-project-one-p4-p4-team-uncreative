using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenePress : MonoBehaviour
{
    // Start is called before the first frame update
    public Start()
    {
        
    }

    // Update is called once per frame
    public void OnMouseUp(string CharacterSelect)
    {
        SceneManager.LoadScene(CharacterSelect);
    }
}
