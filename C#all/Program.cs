
using C_all;




//Fibinacci
Fibinacci fibinacci = new Fibinacci();
Console.WriteLine(fibinacci.Fib(8));

//Factorial
Factorial fib=new Factorial();
Console.WriteLine(fib.fact(4));

//duplicates in string
Duplicates dup = new Duplicates();
List<char> dupsInString = dup.DupChars("CSharpCorner");
foreach (char c in dupsInString)
{
    Console.Write(c+" ");
}
Console.WriteLine();

//duplicate strings 
List<string> dupStrings = dup.DupStrs(["Sunday", "Monday", "Tuesday", "Wednesday", "Sunday", "Monday", "Sunday"]);
foreach (string c in dupStrings)
{
    Console.Write(c + " ");
}
Console.WriteLine();

RemoveDuplicates duprem= new RemoveDuplicates();
string dupremo = duprem.RemoveDuplicateChars("CSharpCorner");
Console.WriteLine(dupremo);

//characters in string
Counts Co = new Counts();
int charsinstr = Co.charsInStr("Csharpcorner");
Console.WriteLine(charsinstr);
Console.WriteLine();

Patterns patterns = new Patterns();
patterns.ReverseTriangle(4);
Console.WriteLine();
patterns.ReverseTriangles(4);
Console.WriteLine();
patterns.InvertedTable(4);
Console.WriteLine();
patterns.Pyramid(4);
Console.WriteLine();


Reverse rev=new Reverse();
Console.WriteLine(rev.RevStr("tihoR"));
Console.WriteLine(rev.ReverseStringRecursive("amileeN"));


Palindrome pal=new Palindrome();
Console.WriteLine(pal.PalCheck("step on no pets"));

Occurrences oc = new Occurrences();
oc.LetterOccurrences("rohit");
Console.WriteLine();
oc.LetterOccurrences("deed");


Substrings sub=new Substrings();
var subs = sub.subStrings("rohi");

Rotations rot=new Rotations();
var rotatedarr = rot.leftRotation([4, 5, 6]);
var roatatedarr2=rot.leftRotation([4, 5, 6],2);
var rightrotatedarr = rot.rightRotation([4, 5, 6,7]);
var rightroatatedarr2 = rot.rightRotation([4, 5, 6,7], 6);

Prime pri = new Prime();
Console.WriteLine(pri.primeCheck(19));


Sums _sums= new Sums();
int sumofdigits = _sums.sumOfDigits(153);
Console.WriteLine(sumofdigits);




