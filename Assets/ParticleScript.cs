using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    [SerializeField] ParticleSystem collisionParticle = null;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Colide();
    }

    public void Colide()
    {
        collisionParticle.Play();
    }


}
