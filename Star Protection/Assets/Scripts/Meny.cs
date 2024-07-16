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

        //если что, логотип игры должен быть только на главном экране 
        //а звезды в первой и второй сцене должны быть разные для более сильного ощущения что это другая сцена
        //и что если сделать чтобы вместо того чтобы скрывать объекты по отдельности, скрывать только пустышку MainMenu/StarsSelectMenu (сам я не трогал, боялся сломать)
    }
}
