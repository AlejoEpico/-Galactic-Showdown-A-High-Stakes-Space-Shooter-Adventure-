using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    public void buttonWork(){
        Debug.Log("Hi Im a button");
        SceneManager.LoadScene(1);
    }

    // public Image lifeBar;
    // public float life;
    // Start is called before the first frame update
    void Start()
    {
        // lifeBar.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        // lifeBar.fillAmount = life / 100;
    }
}
