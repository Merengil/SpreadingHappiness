using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyStatePlaceholder : AbstractHappyState
{
	// Time to wait between 2 shots in seconds.
	public override float CooldownTimeBeforeShooting {get {return 2.0f;}}
	
	public HappyStatePlaceholder(AbstractMagicalGirlController mg) : base(mg)
	{}
		
	public override void Shoot(){this.ShootStraight(90, 300);}
	public override void Move(){}
}
