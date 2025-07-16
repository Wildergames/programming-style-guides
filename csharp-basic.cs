// At the top of each file should be any `usings` or `includes`, sorted by name
using System;

// Each class should exist in a namespace. Failing to add a namespace may cause compilation conflicts.
// For most of our projects, game-specific code exists in the Game namespace, or in a child of Game (Game.Player, Game.Enemies, etc)
namespace Game
// Opening brackets should exist alone on a new line
{
	// Nothing should come between your namespace declaration and your class
	public class ExampleClass : MonoBehaviour
	{
		// public fields come first, at the top of your class, and use PascalCase naming
		public bool IsEnabled = false;

		// private fields come next, under the public fields
		// private fields use camelCase, never starting with an underscore
		private int exampleInteger = 0;
		private string exampleString = "";

		// MonoBehaviour functions (built-in Unity methods) come next, below all field declarations but above most other methods
		// The order of your MonoBehaviour methods should be in order-of-execution, as Unity would call them 
		// For example: OnEnable, Awake, Start methods would be at the top, with Update below them, followed by OnDisable, OnDestroy, etc
		void Awake()
		{
		}

		void Start()
		{
			StartFunction1();
		}

		void Update()
		{
			UpdateExampleFunction1(true);
			UpdateExampleFunction2(false, 100);
		}

		void OnDisable()
		{
		}

		// Under your MonoBehaviour methods is where the rest of your methods/functions should go.
		// Method names are CamelCase, and arguments (member variables) are camelCase without underscores
		// These should be listed in order of importance with an emphasis on accessability (public first, private last) while keeping order of execution in mind
		public void StartFunction1()
		{
		}

		private void UpdateExampleFunction1(bool exampleArgument1)
		{
		}

		private void UpdateExampleFunction2(bool exampleArgument1, int exampleArgument2)
		{
		}
	}
}
