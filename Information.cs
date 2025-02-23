﻿using System;

/*
 * Name/ID: Ellena Begg, 30040389
 * Date: 18 May 2022
 * Version 1.2 After Further Thourough Testing
 * Program Name: Data Structures Wiki 2
 * Description: C# Assessment Task 2
 *              A Class for Data Structure types, that implements IComparable<T>
 */

namespace DataStructuresWiki2
{
    // 6.1 Create a separate class file to hold the four data items of the Data Structure
    [Serializable]
    internal class Information : IComparable<Information>
    {
        // Properties
        private string name;
        private string category;
        private string structure;
        private string definition;

        // Constructor 
        public Information() { }

        // Encapsulation
        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetCategory()
        {
            return category;
        }

        public void SetCategory(string newCategory)
        {
            category = newCategory;
        }

        public string GetStructure()
        {
            return structure;
        }

        public void SetStructure(string newStructure)
        {
            structure = newStructure;
        }

        public string GetDefinition()
        {
            return definition;
        }

        public void SetDefintion(string newDefinition)
        {
            definition = newDefinition;
        }


        // Must overload IComparable.CompareTo method
        public int CompareTo(Information other)
        {
            //TESTING
            //testData += "\nIncoming object NAME value: " + other.GetName();
            //testData += "\nCompared to object NAME Value: " + this.name;

            return this.name.CompareTo(other.name);
        }

        #region TESTING
        //protected static string testData = "Information Class CompareTo method Data\n\n";

        //public static string GetTestData()
        //{
        //    return testData;
        //}
        #endregion
    } // end class Information
} // end namespace DataStructuresWiki2
