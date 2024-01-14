using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyStatePlaceholder : AbstractHappyState
{
	public HappyStatePlaceholder() : base()
	{		
		CooldownTimeBeforeShooting = 2.0f;
	}
	
	public override void Shoot(){}
	public override void Move(){}
}
