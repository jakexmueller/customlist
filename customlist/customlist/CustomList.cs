﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customlist
{
    public class CustomList<T>
    {
        T[] array;               
        private int count;
        private int capacity;
        //Contructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            array = new T[capacity];
            
        }

        //properties

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        
        public void Add(T item)
        {
            if(count >= (capacity*.75))
            {
                capacity *= 2;
                T[] placeHolderArray = new T[capacity];
                for(int i=0; i<count; i++)
                {
                    placeHolderArray[i] = array[i];
                }
                array = placeHolderArray;
            }          
            array[count] = item;
            count++;
        }

        public bool Remove(T item)
        {
            T[] placeHolderArray = new T[capacity];
            for(int i = 0; i<=count; i++)
            {
                if (array[i].Equals(item))
                {
                    return true;
                }
                else
                {
                    placeHolderArray[i] = array[i];
                }
            }
            return true;
        }
        //Array.Resize(ref array, newsize); 
        //array[newsize-1] = "newvalue"

        //will need indexer

        //need array to have any length
    }
}
