using UnityEngine;

public class HeatMapManager : MonoBehaviour
{
    // Declaration of the heatmap particle effect prefab
    public GameObject HeatMapParticleEffectPrefab;
    void FixedUpdate()
    {
        // Initialization of ray with current position as position and forward vector as direction
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // Instantiating the particle effect prefab at the hit point of other collider
            GameObject heat = Instantiate(HeatMapParticleEffectPrefab, hit.point, Quaternion.identity);
            Destroy(heat, 1f);
        }
    }
}





