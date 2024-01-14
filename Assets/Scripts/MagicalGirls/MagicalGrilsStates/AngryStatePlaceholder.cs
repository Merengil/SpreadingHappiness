using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryStatePlaceholder : AbstractAngryState
{	
	public AngryStatePlaceholder() : base()
	{
		CooldownTimeBeforeShooting = 2.0f;
	}

	public override void Shoot(){}
	public override void Move(){}
}
