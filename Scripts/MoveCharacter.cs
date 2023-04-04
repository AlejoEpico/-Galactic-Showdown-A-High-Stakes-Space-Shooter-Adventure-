using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public float speed;
    // public int numberOfItems = 0;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") *speed,0,Input.GetAxis("Vertical")*speed);
        transform.Rotate(0,Input.GetAxis("Mouse X"),0);

         if (Input.GetButtonDown("Fire 1")){
            GameObject auxiliarBullet = Instantiate(bulletPrefab,transform.position + transform.forward * 1, Quaternion.identity);
            auxiliarBullet .GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            Destroy(auxiliarBullet,1);
        }

    }
     private void OnTriggerEnter(Collider other) {
        if(other.name == "Cube A")
        Debug.Log("We are entering in cube A");
        GetComponent<AudioSource>().Play();
    }
     private void OnTriggerExit(Collider other) {
        if(other.tag == "Item")

        FindObjectOfType<Player>().gotchaItem();
        Debug.Log("I toke an item");
        Destroy(other.gameObject);
        // numberOfItems = numberOfItems + 1;
    }




    //  private void OnTriggerExit(Collider other) {
    //     if(other.name == "Cube B")
    //     Debug.Log("Im exit from cube B");
    // }
    // //  private void OnTriggerStay(Collider other) {
    //  private void OnTriggerStay(Collider other) {
    //     if(other.tag == "Zone")
    //     Debug.Log("This is the zone");
    // }
}
