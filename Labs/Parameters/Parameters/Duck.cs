using System;

namespace Parameters
{
    internal class Duck
    {
        public string Name;                     //Declares Name as a field to be used below

        internal void SetName(string name)      //Declares variable name as a string and a parameter of method SetName
        {
            Name = name;                        //Assigns variable name to field Name 
        }
    }
}