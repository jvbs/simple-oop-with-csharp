using System;

public class Youtuber : Creator
{
  public override void Create()
  {
    if (base.CreativityLevel >= 50 && base.Energy >= 50)
    {
      this.BrainstormVideoIdeas();
      this.CreateScript();
      this.VideoTapeScript();
      this.EditingVideo();
      this.UploadingVideo();
    }
    else
    {
      throw new Exception("Cannot create a video. Take a rest.");
    }
  }

  private void BrainstormVideoIdeas()
  {
    base.CreativityLevel = base.CreativityLevel - 15;
    base.Energy = base.Energy - 10;

    Console.WriteLine("Brainstorming video ideas...");
  }

  private void CreateScript()
  {
    base.CreativityLevel = base.CreativityLevel - 5;
    base.Energy = base.Energy - 5;

    Console.WriteLine("Creating script...");
  }

  private void VideoTapeScript()
  {
    base.CreativityLevel = base.CreativityLevel - 7;
    base.Energy = base.Energy - 7;

    Console.WriteLine("Video Tape Script...");
  }

  private void EditingVideo()
  {
    base.CreativityLevel = base.CreativityLevel - 5;
    base.Energy = base.Energy - 10;

    Console.WriteLine("Editing video...");
  }

  private void UploadingVideo()
  {
    base.CreativityLevel = base.CreativityLevel - 3;
    base.Energy = base.Energy - 2;

    Console.WriteLine("Uploading video...");
  }
}