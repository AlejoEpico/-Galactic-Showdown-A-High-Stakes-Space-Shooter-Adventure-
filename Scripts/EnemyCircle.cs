using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyCircle : MonoBehaviour
{
    public int speed;

    public GameObject item;

    public int enemyLife;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
{
    if (item == null)
    {
        return;
    }
    transform.LookAt(item.transform);
    GetComponent<Rigidbody>().velocity = transform.right * speed;
}

    private void OnCollisionEnter(Collision other)
{
    if (other.collider.name == "Player")
    {
        Debug.Log("It's a damage");
            // SceneManager.LoadScene(0);
            FindObjectOfType<Player>().myDamage();

    }
    else if (other.collider.CompareTag("Bullet"))
    {
        Destroy(other.collider.gameObject);
        enemyLife = enemyLife - 1;
        if (enemyLife == 0)
        {
            Destroy(gameObject);
        }
    }
    else if (other.collider.CompareTag("Enemy"))
    {
        // Do nothing if colliding with another enemy
    }
}

}
