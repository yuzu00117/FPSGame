using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // null
    }

    // Update is called once per frame
    void Update()
    {
        // null
    }

    public void StartGame()
    {
        SceneManager.LoadScene ( "Game" );
    }
}
