using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
[CreateAssetMenu(fileName = "Skill", menuName = "Data/Skill/BaseSkill")]
public  class BaseSkill : ScriptableObject
{
    public string skillID;
    public string skillName;
    //是否一次性
    public bool isOneTime;
    //是否为主动技能
    public bool isActive;
    //是否可重复获得
    public bool isRepeatable;
    //技能使用后是否回到技能池
    public bool isUsedReturn;
    public List<BaseEffect> skillEffect;
}