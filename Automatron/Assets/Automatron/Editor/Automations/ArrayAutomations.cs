using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Array/Get Rank" )]
	class ArrayRankGet2 : Automation {

		public System.Array Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Rank;
			yield break;
		}

	}

	[Automation( "Array/Get Is Synchronized" )]
	class ArrayIsSynchronizedGet3 : ConditionalAutomation {

		public System.Array Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.IsSynchronized;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Array/Get Sync Root" )]
	class ArraySyncRootGet4 : Automation {

		public System.Array Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Object Result;

		public override IEnumerator Execute() {
			Result = Instance.SyncRoot;
			yield break;
		}

	}

	[Automation( "Array/Get Is Fixed Size" )]
	class ArrayIsFixedSizeGet5 : ConditionalAutomation {

		public System.Array Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.IsFixedSize;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Array/Get Is Read Only" )]
	class ArrayIsReadOnlyGet6 : ConditionalAutomation {

		public System.Array Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.IsReadOnly;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Array/Get Length" )]
	class ArrayGetLength0 : Automation {

		public System.Array Instance;
		public System.Int32 dimension;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetLength(dimension);
			yield break;
		}

	}

	[Automation( "Array/Get Long Length" )]
	class ArrayGetLongLength1 : Automation {

		public System.Array Instance;
		public System.Int32 dimension;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetLongLength(dimension);
			yield break;
		}

	}

	[Automation( "Array/Get Lower Bound" )]
	class ArrayGetLowerBound2 : Automation {

		public System.Array Instance;
		public System.Int32 dimension;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetLowerBound(dimension);
			yield break;
		}

	}

	[Automation( "Array/Get Upper Bound" )]
	class ArrayGetUpperBound5 : Automation {

		public System.Array Instance;
		public System.Int32 dimension;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetUpperBound(dimension);
			yield break;
		}

	}

	[Automation( "Array/Get Value" )]
	class ArrayGetValue6 : Automation {

		public System.Array Instance;
		public System.Int32 index;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Object Result;

		public override IEnumerator Execute() {
			Result = Instance.GetValue(index);
			yield break;
		}

	}

	[Automation( "Array/Set Value" )]
	class ArraySetValue7 : Automation {

		public System.Array Instance;
		public System.Object value;
		public System.Int32 index;

		public override IEnumerator Execute() {
			Instance.SetValue(value,index);
			yield break;
		}

	}

	[Automation( "Array/Create Instance" )]
	class ArrayCreateInstance8 : Automation {

        [TypeLimit( typeof( object ) )]
        public System.Type elementType;
		public System.Int32 length;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Array Result;

		public override IEnumerator Execute() {
			Result = System.Array.CreateInstance(elementType,length);
			yield break;
		}

	}

	[Automation( "Array/Binary Search" )]
	class ArrayBinarySearch9 : Automation {

		public System.Array array;
		public System.Object value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = System.Array.BinarySearch(array,value);
			yield break;
		}

	}

	[Automation( "Array/Clone" )]
	class ArrayClone10 : Automation {

		public System.Array Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Object Result;

		public override IEnumerator Execute() {
			Result = Instance.Clone();
			yield break;
		}

	}

	[Automation( "Array/Copy" )]
	class ArrayCopy11 : Automation {

		public System.Array sourceArray;
		public System.Array destinationArray;
		public System.Int32 length;

		public override IEnumerator Execute() {
			System.Array.Copy(sourceArray,destinationArray,length);
			yield break;
		}

	}

	[Automation( "Array/Index Of" )]
	class ArrayIndexOf12 : Automation {

		public System.Array array;
		public System.Object value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = System.Array.IndexOf(array,value);
			yield break;
		}

	}

	[Automation( "Array/Last Index Of" )]
	class ArrayLastIndexOf13 : Automation {

		public System.Array array;
		public System.Object value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = System.Array.LastIndexOf(array,value);
			yield break;
		}

	}

	[Automation( "Array/Reverse" )]
	class ArrayReverse14 : Automation {

		public System.Array array;

		public override IEnumerator Execute() {
			System.Array.Reverse(array);
			yield break;
		}

	}

	[Automation( "Array/Sort" )]
	class ArraySort15 : Automation {

		public System.Array array;

		public override IEnumerator Execute() {
			System.Array.Sort(array);
			yield break;
		}

	}

	[Automation( "Array/Copy To" )]
	class ArrayCopyTo16 : Automation {

		public System.Array Instance;
		public System.Array array;
		public System.Int32 index;

		public override IEnumerator Execute() {
			Instance.CopyTo(array,index);
			yield break;
		}

	}

	[Automation( "Array/Constrained Copy" )]
	class ArrayConstrainedCopy17 : Automation {

		public System.Array sourceArray;
		public System.Int32 sourceIndex;
		public System.Array destinationArray;
		public System.Int32 destinationIndex;
		public System.Int32 length;

		public override IEnumerator Execute() {
			System.Array.ConstrainedCopy(sourceArray,sourceIndex,destinationArray,destinationIndex,length);
			yield break;
		}

	}


#pragma warning restore 0649
}
