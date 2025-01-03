using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkillEffect", menuName = "Data/SkillEffect/Normal/A105Effect")]
public class A105Effect : BaseEffect
{
    public override void subscribeEvent()
    {
        DynamicEventBus.Subscribe("AfterEnemyAttackEvent", EventSkill);
    }

    public override void unsubscribeEvent()
    {
        DynamicEventBus.Unsubscribe("AfterEnemyAttackEvent", EventSkill);
    }

    public override void Execute()
    {
        
    }

    public override void ImmediateTrigger()
    {
        
    }
    public void EventSkill()
    {
        GamePointBoard.Instance.attack += 3;
    }

    public override void Interrupt()
    {
        
    }
}
