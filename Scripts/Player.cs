using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Image lifeBar;
    public Text textItems;
    public float life = 100;
    public int items;
    public int maxItems;

    // Start is called before the first frame update
    void Start()
    {
        lifeBar.fillAmount = 1;
        // textItems = GameObject.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void myDamage()
    {
        life = life -50;
        lifeBar.fillAmount = life/100;

        if(life <=0)
        {
            SceneManager.LoadScene(0);
        }
    }
    public void gotchaItem()
    {
        items ++;
        // textItems.text = items.ToString();

        if (items ==  maxItems){
            SceneManager.LoadScene(2);
        }
    
    }
}
