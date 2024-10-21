using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : Skill
{
    [SerializeField] Transform playerTransform;
    [SerializeField] Factory factoryScript;
    public override string skillName => "Fire";

    public override void Activate()
    {
        factoryScript.CreateSkill(gameObject.name, playerTransform);
        Debug.Log("Logica de la habilidad Fire");
    }
}
