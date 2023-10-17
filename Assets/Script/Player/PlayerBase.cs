using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    /// <summary>
    /// 공격력
    /// </summary>
    float damage;
    public float Damage => damage;
    /// <summary>
    /// 공격력%
    /// </summary>
    float multiDamage;
    public float MultiDamage => multiDamage;
    /// <summary>
    /// 공격속도
    /// </summary>
    float attackSpeed;
    public float AttackSpeed => attackSpeed;
    /// <summary>
    /// 크리확률
    /// </summary>
    float critical;
    public float Critical => critical;
    /// <summary>
    /// 크리데미지
    /// </summary>
    float critDamage;
    public float CritDamage => critDamage;
    /// <summary>
    /// 추가 광석 확률
    /// </summary>
    float addOrePercent;
    public float AddOrePercent => addOrePercent;
    /// <summary>
    /// 추가 광석
    /// </summary>
    float addOre;
    public float AddOre => addOre;

    float health;
    public float Health => health;
    // 플레이어에게 장비 착용도 시켜야댐
    // 인벤토리 스크립트 따로 만들기
    // 

}
