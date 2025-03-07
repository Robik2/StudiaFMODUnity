using FMODUnity;
using UnityEngine;

public class FMODEvents : MonoBehaviour {
    public static FMODEvents instance;

    private void Awake() {
        if (instance != null) {
            Debug.LogError("instance AudioManager already exists");
            Destroy(gameObject);
        }

        instance = this;
    }
    
    [field: SerializeField] public EventReference steps;
    [field: SerializeField] public EventReference amb;
}
