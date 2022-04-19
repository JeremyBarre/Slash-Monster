using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bestiary : MonoBehaviour
{

    public GameObject gobbelin;

    public void Gobbelin() {
        gobbelin.SetActive(true);
    }
    public void CloseGobbelin(){
        gobbelin.SetActive(false);
    }
}
