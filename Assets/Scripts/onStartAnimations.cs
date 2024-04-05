using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onStartAnimations : MonoBehaviour
{
    //Start Scene
    public TextMeshProUGUI title;
    public UnityEngine.UI.Button startBTN;
    public UnityEngine.UI.Button settingsBTN;
    public UnityEngine.UI.Button exitBTN;

    //Log In scene
    public UnityEngine.UI.Button logInBTN;
    public UnityEngine.UI.Button forgotBTN;
    public UnityEngine.UI.Button createBTN;
    public UnityEngine.UI.Button backBTN;

    //Create Account Scene
    public UnityEngine.UI.Button createBTN2;
    public UnityEngine.UI.Button logInBTN2;
    public UnityEngine.UI.Button backBTN2;
    void Start()
    {
        //Start Scene
        if (SceneManager.GetActiveScene().buildIndex.Equals(0)) 
        {
            int x1 = Convert.ToInt32(0);
            title.transform.LeanMoveLocal(new Vector2(x1, 609), 1).setEaseInOutBack().setLoopPingPong();

            int x2 = Convert.ToInt32(0);
            startBTN.transform.LeanMoveLocal(new Vector2(x2, 312), 1).setEaseInOutQuart().setLoopPingPong();

            int x3 = Convert.ToInt32(-3.0518e-05);
            settingsBTN.transform.LeanMoveLocal(new Vector2(x3, 139), 1).setEaseInOutBack().setLoopPingPong();

            int x4 = Convert.ToInt32(0);
            exitBTN.transform.LeanMoveLocal(new Vector2(x4, -37), 1).setEaseInOutBack().setLoopPingPong();

        }
        //Log In Scene
        else if (SceneManager.GetActiveScene().buildIndex.Equals(1))
        {
            int x1 = Convert.ToInt32(0);
            logInBTN.transform.LeanMoveLocal(new Vector2(x1, -73), 1).setEaseInOutQuart().setLoopPingPong();

            int x2 = Convert.ToInt32(2.5);
            forgotBTN.transform.LeanMoveLocal(new Vector2(x2, -507), 1).setEaseInOutBack().setLoopPingPong();

            int x3 = Convert.ToInt32(2.5);
            int y3 = Convert.ToInt32(-711.0001);
            createBTN.transform.LeanMoveLocal(new Vector2(x3, y3), 1).setEaseInOutBack().setLoopPingPong();

            int x4 = Convert.ToInt32(0);
            backBTN.transform.LeanMoveLocal(new Vector2(x4, -894), 1).setEaseInOutBack().setLoopPingPong();

        }
        //Create Account Scene
        else if (SceneManager.GetActiveScene().buildIndex.Equals(2))
        {
            int x1 = Convert.ToInt32(0);
            createBTN2.transform.LeanMoveLocal(new Vector2(x1, -379), 1).setEaseInOutBack().setLoopPingPong();

            int x2 = Convert.ToInt32(-3.0518e-05);
            logInBTN2.transform.LeanMoveLocal(new Vector2(x2, -395), 1).setEaseInOutBack().setLoopPingPong();

            int x3 = Convert.ToInt32(-3.0518e-05);
            backBTN2.transform.LeanMoveLocal(new Vector2(x3, -579), 1).setEaseInOutBack().setLoopPingPong();

        }
    }
}
