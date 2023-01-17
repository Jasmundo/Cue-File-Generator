using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CueGenerator
{
    internal class Operations
    {
        public static string GenerateSingleArtist(string filename, string artistName, string rawText, string title, int order, bool includesEndTime, bool isOrdered, string genre ="", string year="")
        {
            StringBuilder cueFile = new StringBuilder();
            bool isArtistEmpty = string.IsNullOrEmpty(artistName);
            if (!string.IsNullOrEmpty(genre)) { cueFile.AppendLine("REM GENRE " + genre); }
            if (!string.IsNullOrEmpty(year)) { cueFile.AppendLine("REM DATE " + year); }
            if (!isArtistEmpty) 
            { 
                cueFile.AppendLine("PERFORMER \"" + artistName + "\""); 
            }
            cueFile.AppendLine("TITLE \"" + title + "\"");
            cueFile.AppendLine("FILE \"" + filename + "\" WAVE");
            rawText = rawText.Trim();
            String[] lines = rawText.Split('\n');
            for (int i = 0; i < lines.Length; ++i)
            {
                if (i < 10) cueFile.AppendLine("  TRACK 0" + (i + 1) + " AUDIO");
                else cueFile.AppendLine("  TRACK " + (i + 1) + " AUDIO");
                if (isOrdered) lines[i] = RemoveSongNumber(lines[i]).Trim();
                int[] markers = FindTimestamp(lines[i]);
                if(markers != null)
                {
                    int length = markers[1] - markers[0];
                    string timestamp = lines[i].Substring(markers[0], length);
                    lines[i] = lines[i].Remove(markers[0],length);
                    
                    if (timestamp.Length > 5)
                    {
                        int hourNumber;
                        int minuteNumber;
                        int newMinuteNumber;
                        if (timestamp[1].Equals(':'))
                        {
                            hourNumber = int.Parse(timestamp.Substring(0 , 1));
                            timestamp = timestamp.Remove(0, 2);
                        }
                        else if (timestamp[2].Equals(':'))
                        {
                            hourNumber = int.Parse(timestamp.Substring(0, 2));
                            timestamp = timestamp.Remove(0, 3);
                        }
                        else
                        {
                            MessageBox.Show("Not all timestamps are properly formated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return "";
                        }
                        minuteNumber = int.Parse(timestamp.Substring(0, 2));
                        timestamp = timestamp.Remove(0, 2);
                        newMinuteNumber = (hourNumber * 60) + minuteNumber;
                        timestamp = timestamp.Insert(0,newMinuteNumber.ToString());
                        if(newMinuteNumber <10) { timestamp = timestamp.Insert(0, "0"); ; }
                    }
                    
                    cueFile.AppendLine("    INDEX 01 " + timestamp + ":00");
                }
                else
                {
                    MessageBox.Show("Not all lines of raw text contain a timestamp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
                if (includesEndTime)
                {
                    int[] additionalMarkers = FindTimestamp(lines[i]);

                    if (additionalMarkers != null)
                    {
                        int length = additionalMarkers[1] - additionalMarkers[0];
                        if (lines[i][additionalMarkers[0] - 1].Equals('-'))
                        {
                            lines[i] = lines[i].Remove(additionalMarkers[0] - 1, length + 1);
                        }
                        else
                        {
                            lines[i] = lines[i].Remove(additionalMarkers[0], length);
                        }
                    }
                }
                int[] extraTimestamp = FindTimestamp(lines[i]);
                if (extraTimestamp != null)
                {
                    MessageBox.Show("At least one line of raw text contains more timestamps than expected. Check if one of the song names/artists contain something that looks like a timestamp(like: '7:00 AM') and if they do, remove it. You can add it manually in the cue file textbox before saving the file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return "";
                }

                lines[i] = lines[i].Trim();
                cueFile.AppendLine("    TITLE \"" + lines[i] +"\"");
                if (!isArtistEmpty) 
                { 
                    cueFile.AppendLine("    PERFORMER \"" + artistName + "\""); 
                }
            }
            return cueFile.ToString();
        }
        public static string GenerateMultipleArtists(string filename, string rawText, string separator1, string title, int order, bool includesEndTime, bool isOrdered, string genre = "", string year = "")
        {
            StringBuilder cueFile = new StringBuilder();
            if (!string.IsNullOrEmpty(genre)) { cueFile.AppendLine("REM GENRE " + genre); }
            if (!string.IsNullOrEmpty(year)) { cueFile.AppendLine("REM DATE " + year); }
            cueFile.AppendLine("TITLE \"" + title + "\"");
            cueFile.AppendLine("FILE \"" + filename + "\" WAVE");
            rawText = rawText.Trim();
            String[] lines = rawText.Split('\n');
            for (int i = 0; i < lines.Length; ++i)
            {
                if (i < 10) cueFile.AppendLine("  TRACK 0" + (i + 1) + " AUDIO");
                else cueFile.AppendLine("  TRACK " + (i + 1) + " AUDIO");
                if (isOrdered) lines[i] = RemoveSongNumber(lines[i]).Trim();
                int[] markers = FindTimestamp(lines[i]);
                if (markers != null)
                {
                    int length = markers[1] - markers[0];
                    string timestamp = lines[i].Substring(markers[0], length);
                    lines[i] = lines[i].Remove(markers[0], length);

                    if (timestamp.Length > 5)
                    {
                        int hourNumber;
                        int minuteNumber;
                        int newMinuteNumber;
                        if (timestamp[1].Equals(':'))
                        {
                            hourNumber = int.Parse(timestamp.Substring(0, 1));
                            timestamp = timestamp.Remove(0, 2);
                        }
                        else if (timestamp[2].Equals(':'))
                        {
                            hourNumber = int.Parse(timestamp.Substring(0, 2));
                            timestamp = timestamp.Remove(0, 3);
                        }
                        else
                        {
                            MessageBox.Show("Not all timestamps are properly formated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return "";
                        }
                        minuteNumber = int.Parse(timestamp.Substring(0, 2));
                        timestamp = timestamp.Remove(0, 2);
                        newMinuteNumber = (hourNumber * 60) + minuteNumber;
                        timestamp = timestamp.Insert(0, newMinuteNumber.ToString());
                        if (newMinuteNumber < 10) { timestamp = timestamp.Insert(0, "0"); ; }
                    }

                    cueFile.AppendLine("    INDEX 01 " + timestamp + ":00");
                }
                else
                {
                    MessageBox.Show("Not all lines of raw text contain a timestamp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
                if (includesEndTime)
                {
                    int[] additionalMarkers = FindTimestamp(lines[i]);

                    if (additionalMarkers != null)
                    {
                        int length = additionalMarkers[1] - additionalMarkers[0];
                        if (lines[i][additionalMarkers[0] - 1].Equals('-'))
                        {
                            lines[i] = lines[i].Remove(additionalMarkers[0] - 1, length + 1);
                        }
                        else
                        {
                            lines[i] = lines[i].Remove(additionalMarkers[0], length);
                        }
                    }
                }
                int[] extraTimestamp = FindTimestamp(lines[i]);
                if (extraTimestamp != null)
                {
                    MessageBox.Show("At least one line of raw text contains more than 2 timestamps. Check if one of the song names/artists contain something that looks like a timestamp(i.e: '7:00 AM') and if they do, remove it. You can add it manually in the cue file textbox before saving the file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return "";
                }

                lines[i] = lines[i].Trim();

                if (!string.IsNullOrEmpty(separator1) && lines[i].Contains(separator1))  
                {
                    String[] artistTitle = lines[i].Split(separator1);
                    if(order == 0)
                    {
                        cueFile.AppendLine("    TITLE \"" + artistTitle[1].Trim() + "\"");
                        cueFile.AppendLine("    PERFORMER \"" + artistTitle[0].Trim() + "\"");
                    }
                    else
                    {
                        cueFile.AppendLine("    TITLE \"" + artistTitle[0].Trim() + "\"");
                        cueFile.AppendLine("    PERFORMER \"" + artistTitle[1].Trim() + "\"");
                    }
                }
                else if(lines[i].Contains(" - "))
                {
                    String[] artistTitle = lines[i].Split(" - ");
                    if (order == 0)
                    {
                        cueFile.AppendLine("    TITLE \"" + artistTitle[1].Trim() + "\"");
                        cueFile.AppendLine("    PERFORMER \"" + artistTitle[0].Trim() + "\"");
                    }
                    else
                    {
                        cueFile.AppendLine("    TITLE \"" + artistTitle[0].Trim() + "\"");
                        cueFile.AppendLine("    PERFORMER \"" + artistTitle[1].Trim() + "\"");
                    }
                }
                else
                {
                    MessageBox.Show("Could not find the specified separator in at least one line of text. Check for a missing spacebar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
            }
            return cueFile.ToString();
        }
        public static string RemoveExtension(string name)
        {
            int startingIndex = name.Length - 5;
            int marker = name.IndexOf('.', startingIndex);
            return name.Remove(marker);
        }
        private static string RemoveSongNumber(string name)
        {
            int marker = name.IndexOf('.');
            if(marker != -1) return name.Remove(0,marker +1);
            else return name;
        }
        private static int[] FindTimestamp(string line)
        {
            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            int[] markers = new int[2];
            bool startMarkerSet = false;
            bool isTimestamp = false;
            for(int i = 0; i < line.Length; ++i) 
            {
                if (chars.Contains(line[i]) && !startMarkerSet)
                {
                    markers[0] = i;
                    startMarkerSet= true;
                }
                else if (startMarkerSet && line[i].Equals(':'))
                {
                    isTimestamp = true;
                }
                else if(!chars.Contains(line[i]) && startMarkerSet && !isTimestamp)
                {
                    startMarkerSet= false;
                }
                else if(!chars.Contains(line[i]) && startMarkerSet && isTimestamp)
                {
                    markers[1] = i;
                    return markers;
                }
                else if(startMarkerSet && isTimestamp && i == line.Length -1) 
                {
                    markers[1] = i + 1;
                    return markers;
                }  
            }
            return null;
        }
    }
}
