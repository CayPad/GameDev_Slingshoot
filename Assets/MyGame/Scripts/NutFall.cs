using UnityEngine;
using System.Collections;

public class NutFall : MonoBehaviour {

  //  public GameObject nf;

    public ParticleSystem nf;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            Debug.Log("buh");
            nf.Play();
        }
    }
}
