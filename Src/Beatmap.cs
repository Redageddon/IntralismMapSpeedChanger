using System.Collections.Generic;

public class Beatmap
{
    public int          configVersion    { get; set; } 
    public string       name             { get; set; } 
    public string       info             { get; set; } 
    public List<object> levelResources   { get; set; } 
    public List<string> tags             { get; set; } 
    public int          handCount        { get; set; } 
    public string       moreInfoURL      { get; set; } 
    public double       speed            { get; set; } 
    public int          lives            { get; set; } 
    public int          maxLives         { get; set; } 
    public string       musicFile        { get; set; } 
    public double       musicTime        { get; set; } 
    public string       iconFile         { get; set; } 
    public int          environmentType  { get; set; } 
    public List<object> unlockConditions { get; set; } 
    public bool         hidden           { get; set; } 
    public List<object> checkpoints      { get; set; } 
    public List<Event> events           { get; set; } 
    public string       e                { get; set; } 
}