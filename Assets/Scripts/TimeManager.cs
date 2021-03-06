using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public new GameObject particleSystem;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject effect = Instantiate(particleSystem);
            effect.GetComponent<ParticleSystem>().Play();
            Destroy(effect, particleSystem.GetComponent<ParticleSystem>().main.duration + 1);//5+1
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        
    }
}
