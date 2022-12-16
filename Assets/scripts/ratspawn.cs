using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ratspawn : MonoBehaviour
{
  
   
    public Rigidbody ratOne;
    public Rigidbody ratTwo;
    public Rigidbody ratThree;
    public bool eat;
    public float eatedRat = 0;
    public Text eatedText;
    public AudioSource eatedAudioSource;
    void Start()
    {
        ratOne.transform.position = new Vector3(Random.Range(-9, 9), -1.134f, Random.Range(-9, 9));
        ratTwo.transform.position = new Vector3(Random.Range(-9, 9), -1.134f, Random.Range(-9, 9));
        ratThree.transform.position = new Vector3(Random.Range(-9, 9), -1.134f, Random.Range(-9, 9));
    }

    // Update is called once per frame
    void Update()
    {
        if (eat)
        {
            eatedRat++;
            eatedAudioSource.Play();
            eat = false;
            eatedText.text = eatedRat.ToString();

        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "rat1")
        {
            ratOne.transform.position = new Vector3(Random.Range(-9, 9), -1.134f, Random.Range(-9, 9));

            eat = true;

        }
        if (other.tag == "rat2")
        {
            ratTwo.transform.position = new Vector3(Random.Range(-9, 9), -1.134f, Random.Range(-9, 9));

            eat = true;

        }
        if (other.tag == "rat3")
        {
            ratThree.transform.position = new Vector3(Random.Range(-9, 9), -1.134f, Random.Range(-9, 9));

            eat = true;

        }

    }
}
