using UnityEngine;
using UnityEngine.AI;

public class DeerW5 : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private void Start()
    {
        NavMeshAgent _agent = GetComponent<NavMeshAgent>();
        _agent.SetDestination(_target.position);
    }
}
        // STEP 1 & 2 ---------------------------------------------------------
        // STEP 1
        // This DeerW5 class is a Component on the Deer GameObject. It controls
        //      the deer's movement.
        //
        // The Deer should move forwards and backwards with the W and S keys.
        //
        // Use the "static properties" listed under the Vector3 documentation:
        //  https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Vector3.html
        //
        // to change the value of the translation variable,
        // and then call Translate on this GameObject's transform to make it move
        // using translation, _moveSpeed, and Time.deltaTime.
        //
        // Ask yourself:
        //      Which axis moves the deer forwards and backwards?
        //      Which Vector3 static property would be useful here based on
        //          changing that axis?
        //      Should I modify translation with Vector addition, or multiplication,
        //          or both?
        //
        // STEP 2
        // After Step 1 is working, add more code to make it possible to flip
        //      the player's control scheme.
        // The _flipWSControls member variable, which we can change in the Inspector,
        //      determines if our controls should be flipped.
        // If _flipWSControls is true, interpret the value of translation as the
        //      OPPOSITE value, so that W moves the player backwards and S moves
        //      them forwards.
        //
        // MULTIPLY one of your vectors with a certain value to do this. >:)
// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...