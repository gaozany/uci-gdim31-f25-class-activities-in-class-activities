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


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
