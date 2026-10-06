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

3. After Step 4, the error “; expected” indicated that the statement was missing a semicolon. Adding it at the end fixed the syntax: `g -= 0.1f;`.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
