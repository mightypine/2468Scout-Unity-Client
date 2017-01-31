﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public class Team
    {
        public string sTeamName;
        public int iTeamNumber, iNumPictures;
        public List<FRCAward> awardsList;

        //ADD GAME SPECIFIC STATS
        public float fAvgGearsPerMatch, fAvgHighFuelPerMatch, fAvgLowFuelPerMatch, fAvgRankingPoints, fHighGoalAccuracy, fClimbAttemptPercent, fTouchpadPercent, fPenaltyLikelihood, fBreakdownLikelihood, fStuckLikelihood;
        public string sBestRole;
        public List<string> sNotesList;
        public int iGamesScouted, iSpeed, iWeight, iStartingPosition, iTeamAge;
    }
}
