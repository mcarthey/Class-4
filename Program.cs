﻿using Class_4.Dao;
using System;

namespace Class_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // First example from class: Exception Handling
            //ExceptionClass.ExampleMethod();

            // Second example from class: Interfaces
            IDataDao dao = new FileDao();
            dao.Read();
            dao.Write();

        }
    }
}
