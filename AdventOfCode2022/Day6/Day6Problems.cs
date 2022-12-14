using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AdventOfCode2022.Util;

namespace AdventOfCode2022.Day6
{
  public class Day6Problems : Problems
  {
    public override string TestInput => @"zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw";

    public override int Day => 6;

    public override string Problem1(string[] input, bool isTestInput)
    {
      var line = input[0];
      var buf = new Queue<char>();
      var curIndex = 0;
      foreach (var c in line)
      {
        buf.Enqueue(c);
        if (buf.Count == 5)
        {
          buf.Dequeue();
        }

        if (buf.Count == 4 && CheckForUniqueness(buf))
        {
          return (curIndex + 1).ToString();
        }

        curIndex++;
      }

      throw new ArgumentException();
    }

    public override string Problem2(string[] input, bool isTestInput)
    {
      var line = input[0];
      var buf = new Queue<char>();
      var curIndex = 0;
      foreach (var c in line)
      {
        buf.Enqueue(c);
        if (buf.Count == 15)
        {
          buf.Dequeue();
        }

        if (buf.Count == 14 && CheckForUniqueness(buf))
        {
          return (curIndex + 1).ToString();
        }

        curIndex++;
      }

      throw new ArgumentException();
    }

    private static bool CheckForUniqueness(Queue<char> buf)
    {
      var hashed = buf.ToHashSet();
      return hashed.Count == buf.Count;
    }
  }
}
