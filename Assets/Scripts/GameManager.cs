using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class Hola
//{
//    static Hola instance;

//    private Hola()
//    {

//    }

//    Hola GetInstance()
//    {
//        if (instance == null)
//        {
//            instance = new Hola();
//        }

//        return instance;
//    }
//}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int[] points;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        points = new int[2];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
