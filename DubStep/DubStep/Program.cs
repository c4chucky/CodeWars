using System;

namespace DubStep
{
  class Program
  {
    static void Main(string[] args)
    {
      GetSongTitle();
      PrintOriginalSongName();
    }

    private static void PrintOriginalSongName()
    {
      Console.WriteLine(RemoveWubsFromTitle(GetSongTitle()));
    }

    private static string GetSongTitle()
    {
      Console.WriteLine("Hello.\nPlease Enter a DubStep Song title: ");
      string title = Console.ReadLine();
      EmptyStringTest(title);
      return title;
    }

    private static string EmptyStringTest(string title)
    {
      while (title == "")
        title = Console.ReadLine();
      return title;
    }

    public static string RemoveWubsFromTitle(string songTitle)
    {
      string[] splitSongTitle = songTitle.Split("WUB");
      string title = SongNameBuilder(splitSongTitle);

      songTitle = title.Trim();

      return songTitle;
    }

    private static string SongNameBuilder(string[] splitSongTitle)
    {
      string title = "";
      return ConcatSplitString(splitSongTitle, title);
    }

    private static string ConcatSplitString(string[] splitSongTitle, string title)
    {
      foreach (var word in splitSongTitle)
      {
        title = SongTitleBuilder(title, word);
      }

      return title;
    }

    private static string SongTitleBuilder(string title, string word)
    {
      if (word != "")
        title += (word + " ");
      return title;
    }
  }
}
