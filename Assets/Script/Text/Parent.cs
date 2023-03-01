using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{
    [SerializeField] private GameObject floatingTextPrefab ; 

    public void TakeText(int text)
    {
        ShowText(text.ToString());
    }
    void ShowText(string text)
    {
        if (floatingTextPrefab)
        {
            GameObject prefab = Instantiate(floatingTextPrefab, transform.position, Quaternion.identity);
            prefab.GetComponentInChildren<TextMesh>().text = text;
        }

    }
}
