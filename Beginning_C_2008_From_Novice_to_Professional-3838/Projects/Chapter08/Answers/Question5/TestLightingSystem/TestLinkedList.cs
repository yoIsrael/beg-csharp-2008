﻿using LibLightingSystem;
using System;

namespace TestLightingSystem {
    class LinkedItem : BaseLinkedList {
        private string _identifier;
        public LinkedItem(string identifier) {
            _identifier = identifier;
        }
        public string Identifier {
            get {
                return _identifier;
            }
        }
        public override string ToString() {
            string buffer;
            buffer = "this(" + _identifier + ")";
            if (Next != null) {
                buffer += " next(" + ((LinkedItem)Next).Identifier + ")";
            }
            else {
                buffer += " next(null)";
            }
            if (Prev != null) {
                buffer += " prev(" + ((LinkedItem)Prev).Identifier + ")";
            }
            else {
                buffer += " prev(null)";
            }
            return buffer;
        }
    }

    public static class TestsLinkedList {
        public static void TestInsert() {
            Console.WriteLine("**************");
            Console.WriteLine("TestInsert: Start");
            LinkedItem item1 = new LinkedItem("item1");
            LinkedItem item2 = new LinkedItem("item2");
            LinkedItem item3 = new LinkedItem("item3");

            string toString = item1.ToString();
            Console.WriteLine(toString);
            if (item1.Next != null || item1.Prev != null) {
                throw new Exception("TestInsert: Empty structure is incorrect");
            }

            item1.Insert(item2);
            toString = item1.ToString();
            Console.WriteLine(toString);
            if (!(item1.Next == item2 && item1.Prev == null)) {
                throw new Exception("TestInsert: Item 1->Item2 structure is incorrect");
            }
            toString = item2.ToString();
            Console.WriteLine(toString);
            if (!(item2.Next == null && item2.Prev == item1)) {
                throw new Exception("TestInsert: Item 2->Item1 structure is incorrect");
            }
            item2.Insert(item3);
            toString = item2.ToString();
            Console.WriteLine(toString);
            if (!(item2.Prev == item1 && item2.Next == item3)) {
                throw new Exception("TestInsert: Item2->Item1, Item3 structure is incorrect");
            }
            toString = item3.ToString();
            Console.WriteLine(toString);
            if (!(item3.Prev == item2 && item3.Next == null)) {
                throw new Exception("TestInsert: Item3->Item2, structure is incorrect");
            }

            toString = item1.ToString();
            Console.WriteLine(toString);
            toString = item2.ToString();
            Console.WriteLine(toString);
            toString = item3.ToString();
            Console.WriteLine(toString);
            Console.WriteLine("TestInsert: End");
        }
        // The idea is to try out different insert variations where some could be
        public static void TestInsertVariatio1n() {
            LinkedItem item1 = new LinkedItem("item1");
            LinkedItem item2 = new LinkedItem("item2");
            LinkedItem item3 = new LinkedItem("item3");

            item2.Insert(item1);
            item1.Insert(item3);
        }
        public static void TestRemove1() {
            Console.WriteLine("**************");
            Console.WriteLine("TestRemove1: Start");
            LinkedItem item1 = new LinkedItem("item1");
            LinkedItem item2 = new LinkedItem("item2");
            LinkedItem item3 = new LinkedItem("item3");

            item1.Insert(item2);
            item2.Insert(item3);

            item2.Remove();
            string toString = item1.ToString();
            Console.WriteLine(toString);
            toString = item2.ToString();
            Console.WriteLine(toString);
            toString = item3.ToString();
            Console.WriteLine(toString);
            if (!(item1.Next == item3 && item1.Prev == null)) {
                throw new Exception("TestRemove1: Item1 structure incorrect");
            }
            if (!(item2.Next == null && item2.Prev == null)) {
                throw new Exception("TestRemove1: Item2 structure incorrect");
            }
            if (!(item3.Next == null && item3.Prev == item1)) {
                throw new Exception("TestRemove1: Item3 structure incorrect");
            }
            Console.WriteLine("TestRemove1: End");
        }
        public static void TestRemove2() {
            Console.WriteLine("**************");
            Console.WriteLine("TestRemove2: Start");
            LinkedItem item1 = new LinkedItem("item1");
            LinkedItem item2 = new LinkedItem("item2");
            LinkedItem item3 = new LinkedItem("item3");

            item1.Insert(item2);
            item2.Insert(item3);

            item1.Remove();
            string toString = item1.ToString();
            Console.WriteLine(toString);
            toString = item2.ToString();
            Console.WriteLine(toString);
            toString = item3.ToString();
            Console.WriteLine(toString);
            if (!(item1.Next == null && item1.Prev == null)) {
                throw new Exception("TestRemove2: Item1 structure incorrect");
            }
            if (!(item2.Next == item3 && item2.Prev == null)) {
                throw new Exception("TestRemove2: Item2 structure incorrect");
            }
            if (!(item3.Next == null && item3.Prev == item2)) {
                throw new Exception("TestRemove2: Item3 structure incorrect");
            }
            Console.WriteLine("TestRemove2: End");
        }
        public static void RunAll() {
            TestInsert();
            TestRemove1();
            TestRemove2();
        }
    }
}