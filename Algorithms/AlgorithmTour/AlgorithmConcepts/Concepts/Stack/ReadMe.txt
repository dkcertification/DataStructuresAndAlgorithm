Stack is an Abstract DataType
Implements LIFO ( Last In and First Out)
Operations
	Push - Add Item to the TOP
	Peek - Get the TOP Item without Removing
	Pop - remove the TOP Item

Implementations are backed up by LinkedList OR Array

Characterstics:
	Peek - O(N) time complexity in any case
	If Stack is implemented using LinkedList, then PUSH / POP operations would work for O(1)
	If Stack is implenented using Array
		- PUSH operation would work for O(1) when there is enough space
		- PUSH operation would work for O(N) when there is not enouogh space due to resizing of Array
		- POP works for O(1) when we never shrink Array and O(N) if we shrink Array
Decision Making : 
		- If there is enough memory on device and the max number of Items are not known, then we should consider LinkedList as preferable backing datastructure
		- If there is not enough memory on device and the max number of Items are known, then we should consider Array as preferable backing datastructure
