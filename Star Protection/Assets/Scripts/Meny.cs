using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meny : MonoBehaviour
{
    [SerializeField] GameObject one;
    [SerializeField] GameObject two;
    [SerializeField] GameObject three;
    public void one_meny(){
        one.gameObject.SetActive(true);
        two.gameObject.SetActive(false);
        three.gameObject.SetActive(false);
    }
    public void two_meny(){
        one.gameObject.SetActive(false);
        two.gameObject.SetActive(true);
        three.gameObject.SetActive(false);
    }
    public void three_meny(){
        one.gameObject.SetActive(false);
        two.gameObject.SetActive(false);
        three.gameObject.SetActive(true);
    }
}
