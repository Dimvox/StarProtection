using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Meny : MonoBehaviour
{
    [SerializeField] GameObject Main;
    [SerializeField] GameObject Setin;
    [SerializeField] GameObject Stars;
    [SerializeField] GameObject Materials;
    public void to_main(){
        Main.gameObject.SetActive(true);
        Setin.gameObject.SetActive(false);
        Stars.gameObject.SetActive(false);
        Materials.gameObject.SetActive(false);
    }
    public void to_set(){
        Main.gameObject.SetActive(false);
        Setin.gameObject.SetActive(true);
        Stars.gameObject.SetActive(false);
        Materials.gameObject.SetActive(false);
    }
    public void to_stars(){
        Main.gameObject.SetActive(false);
        Setin.gameObject.SetActive(false);
        Stars.gameObject.SetActive(true);
        Materials.gameObject.SetActive(false);
    }
    public void to_maters(){
        Main.gameObject.SetActive(false);
        Setin.gameObject.SetActive(false);
        Stars.gameObject.SetActive(false);
        Materials.gameObject.SetActive(true);
    }
    public void sc_star1(){
        SceneManager.LoadScene(1);
    }
}
