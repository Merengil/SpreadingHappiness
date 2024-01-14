using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The abstract mother magical girl class.
// All magical girls inherit from this
public abstract class AbstractMagicalGirlController : MonoBehaviour
{
	private float cooldownShootingTimer;
	
	// Each magical girl type has one angrystate and one happystate
	// that inherit from these two abstract classes.
	protected AbstractAngryState angryState;
	protected AbstractHappyState happyState;

	// we're using a State DP. Each state has 2 methods: Move() and Shoot()
	// Happy States will be shooting good bullets to help the MC
	// Angry States will be shooting stuff for the MC to avoid
	protected AbstractMagicalGirlState magicalGirlState;
	
	// ************************************************************************
	
	// Constructor
	public AbstractMagicalGirlController() : base()
	{
		float cooldownShootingTimer = 0;		
	}	
	
	// ************************************************************************
	
	public void TurnHappy()
	{
		// DO STUFF HERE
		magicalGirlState = happyState;
		
		// Resets the firing cooldown.
		cooldownShootingTimer = magicalGirlState.CooldownTimeBeforeShooting;
	}	
	
	// ************************************************************************
	
    // Start is called before the first frame update
    void Start()
    {
        cooldownShootingTimer = magicalGirlState.CooldownTimeBeforeShooting;
    }

	// ************************************************************************
	
    // Update is called once per frame
    void Update()
    {        
        cooldownShootingTimer -= Time.deltaTime;
		if (cooldownShootingTimer < 0)
		{
			// Shoots once the timer is over.
			magicalGirlState.Shoot();
			cooldownShootingTimer += magicalGirlState.CooldownTimeBeforeShooting;
		}
    }
}
