using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPuzzleScript : MonoBehaviour
{ 
    public GameObject myPanel;

    public GameObject WinPanel;

    void Start()
    {
        WinPanel.SetActive(false);
    }

    
    void Update()
    {
        if (Form1.locked && Form2.locked && Form3.locked && Form4.locked &&
            Form5.locked && Form6.locked && Form7.locked )
        {
            myPanel.SetActive(false);
            WinPanel.SetActive(true);
        }
    }

   
}
