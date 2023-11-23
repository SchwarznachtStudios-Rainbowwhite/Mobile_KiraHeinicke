using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public GameObject _Sphere;
    public Button _Button;


    private void OnMouseDown()
    {
        // Color pf Sphere become red

        _Sphere.GetComponent<MeshRenderer>().material.color = Color.red;

    }

    public void ButtonChangingColor()
    {
        //Button to green, if green to white

        //wenn man denkt der BUTTON soll die farbe ändern
        /*if (_Button.targetGraphic.color == Color.white)
        {
            _Button.targetGraphic.color = Color.green;


        }
        else _Button.targetGraphic.color = Color.white;*/

        //aber es soll die kugel sein..
        if (_Sphere.GetComponent<MeshRenderer>().material.color == Color.white)
        {
            _Sphere.GetComponent<MeshRenderer>().material.color = Color.green;


        }
        else _Sphere.GetComponent<MeshRenderer>().material.color = Color.white;


    }

}
