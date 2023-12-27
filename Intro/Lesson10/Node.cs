using System;
using System.Collections.Generic;

namespace Intro.Lesson10
{
    /// <summary>
    /// Represents a node in the <see cref="CustomLinkedList{T}"/>
    /// </summary>
    /// <param name="T">The generic type of the elements in the linked list.</param>
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value) {
            this.Value = value;
            this.Next = null;
        }
    }
}