using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : Skill
{
    [SerializeField] Transform playerTransform;
    [SerializeField] Factory factoryScript;
    public override string skillName => "Heal";

    public override void Activate()
    {
        factoryScript.CreateSkill(gameObject.name, playerTransform);
        Debug.Log("Logica de la habilidad Heal");
    }
     
}
