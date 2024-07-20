using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public enum EnemyState{
    PATROL,
    CHASE,
    ATTACK
}
public class EnemyController : MonoBehaviour
{
    private EnemyAnimator enemy_Anim;
    private NavMeshAgent NavAgent;
    private EnemyState enemy_State;

    public float walk_Speed = 0.5f;

    public float run_Speed = 4f;

    public float chase_Distance = 7f;
    private float current_Chase_Distance;

    public float attack_Distance = 1.8f;
    public float chase_After_Attack_Distance = 2f;
     
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
