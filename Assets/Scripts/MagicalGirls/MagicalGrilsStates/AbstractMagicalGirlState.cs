using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractMagicalGirlState
{
	// Time to wait between 2 shots in seconds.
	public float CooldownTimeBeforeShooting;
	
	public abstract void Shoot();
	public abstract void Move();
}
