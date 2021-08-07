using System;

public class Programmer : Creator
{
  public override void Create()
  {
    if (base.CreativityLevel >= 70 && base.Energy >= 80)
    {
      this.BrainstormSolutions();
      this.PickMostOptimalSolution();
      this.WriteCode();
      this.TestCode();
    }
    else
    {
      throw new Exception("Cannot create a program. Out of idead and/or am tired.");
    }
  }

  private void BrainstormSolutions()
  {
    base.CreativityLevel = base.CreativityLevel - 15;
    base.Energy = base.Energy - 10;

    Console.WriteLine("Brainstorming solutions...");
  }

  private void PickMostOptimalSolution()
  {
    base.CreativityLevel = base.CreativityLevel - 5;
    base.Energy = base.Energy - 5;

    Console.WriteLine("Picking most optimal solution...");
  }

  private void WriteCode()
  {
    base.CreativityLevel = base.CreativityLevel - 7;
    base.Energy = base.Energy - 7;

    Console.WriteLine("Coding...");
  }

  private void TestCode()
  {
    base.CreativityLevel = base.CreativityLevel - 5;
    base.Energy = base.Energy - 10;

    Console.WriteLine("Testing code...");
  }
}