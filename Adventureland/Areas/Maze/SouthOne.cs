﻿/*
 * Implements the Narrow Ledge by Chasm area
 * @Author Eric, Cole, Evan, Logan, Sam
 */
using System;
using System.Collections.Generic;
using Adventureland.Text_Controller;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventureland.Maze
{
   class SouthOne : Area
   {
      private Quest quest;
      public bool isDark;
      private List<AdventurelandItems> itemsInArea;

      public SouthOne(Quest quest) : base(quest)
      {
         this.quest = quest;
         isDark = true;
         itemsInArea = new List<AdventurelandItems>();
      }

      public override bool GetDark()
      {
         return isDark;
      }

      public override void AddItem(AdventurelandItems item)
      {
         itemsInArea.Add(item);
      }

      public override string GetAreaBio()
      {
         return "You are in a maze of pits.";
      }

      public override AdventurelandAreas GetAreaIdentifier()
      {
         return AdventurelandAreas.SouthOne;
      }

      public override List<AdventurelandItems> GetAreaItems()
      {
         return itemsInArea;
      }

      public override string GetAreaName()
      {
         return "Maze";
      }

      public override string GetAreaText()
      {
         string areaText = "You can also see: ";
         foreach (AdventurelandItems item in itemsInArea)
         {
            areaText += " " + Output.OutputInstance.FormatItemText(item) + " -";
         }
         return areaText;
      }

      public override string GetObviousExits()
      {
         return "Obvious Exits: North, East, South, West.";
      }

      public override AdventurelandAreas GoDown()
      {
         return AdventurelandAreas.Invalid_Area;
      }

      public override AdventurelandAreas GoEast()
      {
         return AdventurelandAreas.SouthEastOne;
      }

      public override AdventurelandAreas GoNorth()
      {
         return AdventurelandAreas.Entrance;
      }

      public override AdventurelandAreas GoSouth()
      {
         return AdventurelandAreas.SouthTwo;
      }

      public override AdventurelandAreas GoUp()
      {
         return AdventurelandAreas.Invalid_Area;
      }

      public override AdventurelandAreas GoWest()
      {
         return AdventurelandAreas.SouthEastTwo;
      }

      public override void InitializeAreaItems() { }

      public override void RemoveItem(AdventurelandItems item)
      {
         itemsInArea.Remove(item);
      }

      public override bool HasItem(AdventurelandItems item)
      {
         List<AdventurelandItems> currItems = itemsInArea;

         for (int i = 0; i < currItems.Count; i++)
         {
            if (currItems[i] == item)
            {
               return true;
            }
         }
         return false;
      }
   }
}
