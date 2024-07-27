using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinAnimals : MonoBehaviour
{
    public GameObject myPanel;
    public GameObject WinPanel;

    void Start()
    {
        WinPanel.SetActive(false);
    }


    void Update()
    {
        if (Bear.locked && Fox.locked && Raccon.locked)
        {
            myPanel.SetActive(true);
            WinPanel.SetActive(true);
        }
    }


}
