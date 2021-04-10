using System;

namespace JavaToCsharp_Report
{
    interface IStack
    {
        bool isEmpty();
        void push(char item);
        char pop();
        void delete();
        char peek();
    }
}
