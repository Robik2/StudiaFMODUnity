using FMOD.Studio;
using UnityEngine;
using FMODUnity;

public class AudioManager : MonoBehaviour {
    public static AudioManager instance;

    private void Awake() {
        if (instance != null) {
            Debug.LogError("instance AudioManager already exists");
            Destroy(gameObject);
        }

        instance = this;
    }

    public EventInstance CreateInstance(EventReference eventReference) {
        EventInstance eventInstance = RuntimeManager.CreateInstance(eventReference);
        return eventInstance;
    }
    
    public EventInstance CreateInstance(EventReference eventReference, GameObject obj, Rigidbody2D rb) {
        EventInstance eventInstance = RuntimeManager.CreateInstance(eventReference);
        RuntimeManager.AttachInstanceToGameObject(eventInstance, obj, rb);
        return eventInstance;
    }
}
