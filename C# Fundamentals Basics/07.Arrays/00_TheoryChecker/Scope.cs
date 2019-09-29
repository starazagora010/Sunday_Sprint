namespace _00_TheoryChecker
{
    using System;

    public class Scope
    {
        void Compiler_StronglyTyped()
        {
            int v;

            do
            {
                v = 1;
                int b = 0;
                Console.WriteLine(v);
            }
            while (v > 0 /*&&  b == 0 */);
            //Console.WriteLine(b);

            // interpreted Programming Language like JS will use hoisting
            // validate => v, if var/let type is used ==> scope valid for the interpreter
            // validate => b, if var type is used, BUT invalid => b is let
        }
    }
}