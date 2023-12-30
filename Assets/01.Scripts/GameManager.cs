using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Instance
    private static GameManager _instance;

    public static GameManager Instance {
        get {
            if(_instance == null)
                _instance = new GameManager();

            return _instance;
        }
    }

    
    //Var
    public float speed = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
