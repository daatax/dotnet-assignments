using System;
using System.Collections.Generic;

namespace Intro.Lesson10
{
    public class CustomLinkedList<T>
    {
        private Node<T> head;

        /// <summary>
        /// Adds a generic element of type T to the beginning of the <see cref="CustomLinkedList{T}"/>.
        /// </summary>
        /// <param name="item">The generic item to be added.</param>
        public void AddFirst(T item) {
            Node<T> nodeToAdd = new Node<T>(item);
            nodeToAdd.Next = head;
            head = nodeToAdd;
        }

        /// <summary>
        /// Adds a generic element of type T to the end of the <see cref="CustomLinkedList{T}"/>.
        /// </summary>
        /// <param name="item">The generic item to be added.</param>
        public void AddLast(T item) {
            Node<T> nodeToAdd = new Node<T>(item);

            // if the user tries to add a node in a CustomLinkedList and the it's emtpy -- the parameter will be added as head node.
            if (head == null) {
                head = nodeToAdd;
            }
            else {
                Node<T> currentNode = head;

                // Loop to get the last node
                while (currentNode.Next != null) {
                    currentNode = currentNode.Next;
                }
                // assign the node as the Next of the last found node
                currentNode.Next = nodeToAdd;
            }
        }

        /// <summary>
        /// Removes the first occurrence of a specified element of type T from the <see cref="CustomLinkedList{T}"/>.
        /// </summary>
        /// <param name="item">The generic item to be removed.</param>
        public void Remove(T item) {

            if (head == null) {
                return;
            }
            // remove head node if the first occurrence's value is equal to the head's value
            // reassign the head to the next node -- shit by one to left
            if (head.Value.Equals(item)) {
                head = head.Next;
                return;
            }

            // shif the reference by one to left if the occurrence's value is equal to the current node's value
            Node<T> currentNode = head;
            while (currentNode.Next != null) {
                if (currentNode.Value.Equals(item)) {
                    currentNode.Next = currentNode.Next.Next;
                    return;
                }
                currentNode = currentNode.Next;
            }
        }

        /// <summary>
        /// Checks if a specified element of type T is present in the  <see cref="CustomLinkedList{T}"/>.
        /// </summary>
        /// <param name="item">The generic item to be checked.</param>
        /// <returns>True if the item is found; otherwise, false.</returns>
        public bool Contains(T item) {
            Node<T> currentNode = head;

            while (currentNode != null) {
                // if the current node's value is equal to the item's value, return true, otherwise loop
                if (currentNode.Value.Equals(item)) {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }
    }
}