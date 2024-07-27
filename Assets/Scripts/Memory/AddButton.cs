using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButton : MonoBehaviour
{
    [SerializeField] private Transform puzzleField;
    [SerializeField] private GameObject bttn;

    void Awake()
    {
        for (int i = 0; i < 8; i++)
        {
            GameObject button = Instantiate(bttn);
            button.name = "" + i;
            button.transform.SetParent(puzzleField, false);
        }
    }
}
