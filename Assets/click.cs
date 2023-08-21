using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour {

    public string myGlobalVar = "whatever";
    public GameObject obj0;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;

    public void Obj0Click()
    {
        myGlobalVar = "0";

    }
    public void Obj1Click()
    {
        myGlobalVar = "1";

    }
    public void Obj2Click()
    {
        myGlobalVar = "2";

    }
    public void Obj3Click()
    {
        myGlobalVar = "3";

    }
    public void Obj4Click()
    {
        myGlobalVar = "4";

    }
    public void Obj5Click()
    {
        myGlobalVar = "5";

    }
    public void Obj6Click()
    {
        myGlobalVar = "6";

    }
    public void Obj7Click()
    {
        myGlobalVar = "7";

    }
    public void Obj8Click()
    {
        myGlobalVar = "8";

    }
    public void Obj9Click()
    {
        myGlobalVar = "9";
        
    }

    public void Show()
    {

        if (myGlobalVar == "9")
        {
            obj9.SetActive(true);
        }
        else if (myGlobalVar == "8")
        {
            obj8.SetActive(true);
        }
        else if (myGlobalVar == "7")
        {
            obj7.SetActive(true);
        }
        else if (myGlobalVar == "6")
        {
            obj6.SetActive(true);
        }
        else if (myGlobalVar == "5")
        {
            obj5.SetActive(true);
        }
        else if (myGlobalVar == "4")
        {
            obj4.SetActive(true);
        }
        else if (myGlobalVar == "3")
        {
            obj3.SetActive(true);
        }
        else if (myGlobalVar == "2")
        {
            obj2.SetActive(true);
        }
        else if (myGlobalVar == "1")
        {
            obj1.SetActive(true);
        }
        else
        {
            obj0.SetActive(true);
        }


    }

    public void Hide()
    {

        if (myGlobalVar == "9")
        {
            obj9.SetActive(false);
        }
        else if (myGlobalVar == "8")
        {
            obj8.SetActive(false);
        }
        else if (myGlobalVar == "7")
        {
            obj7.SetActive(false);
        }
        else if (myGlobalVar == "6")
        {
            obj6.SetActive(false);
        }
        else if (myGlobalVar == "5")
        {
            obj5.SetActive(false);
        }
        else if (myGlobalVar == "4")
        {
            obj4.SetActive(false);
        }
        else if (myGlobalVar == "3")
        {
            obj3.SetActive(false);
        }
        else if (myGlobalVar == "2")
        {
            obj2.SetActive(false);
        }
        else if (myGlobalVar == "1")
        {
            obj1.SetActive(false);
        }
        else
        {
            obj0.SetActive(false);
        }
    }


}
