# in-class-activities
## Devlogs
### W1
Gaozan Ye, he/him

After I moved the camera out of the cat GameObject, the camera stopped following the cat because it was no longer a child of the cat and no longer inherited its movement.
[itch link](https://gaozany.itch.io/gdim-31-w1-in-class-activity)

### W2
Gaozan Ye, he/him

Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.
1. The r, g, and b variables are floats because RGB values use decimal numbers between 0 and 1, such as 0.3 or 0.7. Integers cannot represent these fractional values, bools only represent true or false, and strings store text.

2. The bounce counter is an int because it counts whole-number events: 0, 1, 2, and so on. Each collision adds one bounce, so decimal values are unnecessary. A bool cannot store a count, and a string would store it as text instead of a number.

3. After Step 4, the error “; expected” indicated that the statement was missing a semicolon. Adding it at the end fixed the syntax: g -= 0.1f;

### W3
Table 17 
### Activity1 :
1.GetResponse
Parameters: int friendshipLevel and bool knowsSecret.Return type: string.
The friendship level is assumed to be a whole number, and the secret flag is either true or false. The method returns the character’s dialogue as text.
2.SetLightDimness
Parameter: float sanityLevel, ranging from 0 to 100.
Return type: void.
A float allows decimal values. The method changes the lights directly, so it does not need to return a value.
3.DidPlayerHitBeat
Parameter: float pressTime.
Return type: bool.
The input records when the player pressed the key. The method returns true for an accurate hit and false otherwise. I assume the target beat time and timing tolerance are already stored elsewhere in the game.

### Activity2 :
I would compare classes and Components to Phoenix’s fireball ability in Valorant. A class is like the blueprint for the ability, while a Component is an instance of that ability attached to Phoenix’s character GameObject. Member variables store values such as damage, radius, and duration. Methods define actions the ability can perform, such as casting the fireball. The same blueprint could create multiple ability Components with different values.

### Activity3 :
At first, I could not see any color changes with the default speed threshold of 10. I changed the threshold to 0 for testing and saw the balls become brighter. I then tried thresholds of 3 and 5 and also observed the effect. This showed me that the color changes depend on whether the ball’s average speed exceeds the threshold. When it does, each collision multiplies the current RGB color values by 1.5. The changes accumulate because the code uses the updated color each time and does not limit the values. After enough collisions, all three RGB components of my chosen colors became very high, making the balls appear extremely bright and eventually white.

### W4 :
Gaozan Ye, he/him
Table 8

1. We added Rigidbody components to the "cat" and the "soccer ball" because they need to move and interact with the physics system. We did not add a Rigidbody to the "goal" since it does not need to move; instead, we simply enabled the "Is Trigger" option on its Box Collider. This allows the code to detect a "goal scored" event when the soccer ball passes through the goal area. The colliders for the cat and the soccer ball were not set as triggers, as they need to engage in physical collisions with other objects.

2. The game did not function as expected when first run. Because the Debug.Log statements were still commented out, no information was being output. Additionally, I had incorrectly placed the MadeGoal method inside OnTriggerEnter, which caused the code to throw errors. I moved MadeGoal outside of OnTriggerEnter and removed the comment markers. Furthermore, the soccer ball was not rolling continuously as it did in the video—it was coming to a stop too quickly—so I removed the "Freeze Rotation" constraints on its X and Z axes.

### W6 :
Table Number 8, work with Wei Chen

1. I was thinking that the DeerW5 class needs a Transform variable called _target to store and keep the GameObject that the deer will walk toward. My partner and I will use [SerializeField] like the CatW5 so I can choose the target in the Unity Inspector. For this activity, I decided to use the Cat GameObject as the target.

2. Me and my partner chose a plan to use the Start() method that Unity provides since we only need to set the deer's destination when the game begins, and we do not have to worry about it afterward. I did not think we needed an Update() method because the NavMeshAgent can handle the movement after receiving its destination by itself.

3. When the game get started, the Start() method should use GetComponent<NavMeshAgent>() to get the NavMeshAgent Component attached to the Deer. Then, it should call SetDestination() using the Cat's position through _target.position. This will allow the deer to automatically walk toward the Cat's starting position by following the NavMesh.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
