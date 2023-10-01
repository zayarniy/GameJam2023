using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject gameObject = collision.gameObject;
        TMPro.TextMeshProUGUI el = GetComponentInChildren<TMPro.TextMeshProUGUI>();
        print("Collision!"+el.text);

    }

    private void OnTriggerEnter(Collider other)
    {
        //GameObject gameObject = other.gameObject;
        var el = GetComponentInChildren<TMPro.TextMeshPro>();
        print("Collision!" + el.text);
        gameManager.Word(el.text[0]);
        GameObject.Destroy(gameObject);
        
        

    }


}
