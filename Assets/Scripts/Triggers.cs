using UnityEngine;
using UnityEngine.Playables;

public class Triggers : MonoBehaviour
{
    public PlayableDirector timeline;
    
    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();
    }
}
