using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] private Skill[] skills;

    private Dictionary<string, Skill> skillsByName;
    public static Factory factoryInstance {  get; private set; }
    private void Awake()
    {
        skillsByName = new Dictionary<string, Skill>();

        foreach (var skill in skills)
        {
            skillsByName.Add(skill.skillName, skill);
        }
    }

    public Skill CreateSkill(string skillName, Transform playerTransform)
    {
        if (skillsByName.TryGetValue(skillName, out Skill skillPrefab))
        {
            // Crea una instancia de la habilidad en la posición del jugador. 
            Skill skillInstance = Instantiate(skillPrefab, playerTransform.position, Quaternion.identity);
            return skillInstance;
        }
        else
        {
            Debug.LogWarning($"La habilidad '{skillName}' no existe en la base de datos de habilidades.");
            return null;
        }
    }
}
