using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SpawnSpell : MonoBehaviour
{
    [Tooltip("Spawn point for spell")]
    public GameObject spawnPoint;

    [Tooltip("Spell to spawn")]
    public GameObject spellToSpawn;

    public void Spawn()
    {
        if (spawnPoint == null)
        {
            Debug.LogWarning("There is no Spawn Point");
            return;
        }

        if (spellToSpawn == null)
        {
            Debug.LogWarning("There is no spell to spawn");
            return;
        }

        var spellClone = Instantiate(spellToSpawn, spawnPoint.transform.position, Quaternion.identity);
        spellClone.SetActive(true);
    }

    public void SetSpell(GameObject spell)
    {
        spellToSpawn = spell;
    }
}
