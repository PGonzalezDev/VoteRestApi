﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VotesRestApi.Core.Enums;

namespace VotesRestApi.Core.Models
{
    public class Vote
    {
        public Guid Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Comment { get; set; }

        [Required]
        public Guid VotingUserId { get; set; }

        public string VotingUserName { get; set; }

        [Required]
        public Guid VotedUserId { get; set; }

        public string VotedUserName { get; set; }

        [Required]
        public Nomination Nomination { get; set; }

        public string NominationDescription
        {
            get
            {
                string description = string.Empty;

                switch (Nomination)
                {
                    case Nomination.TeamPlayer:
                        description = "Team Player";
                        break;
                    case Nomination.TechnicalReferent:
                        description = "Technical Referent";
                        break;
                    case Nomination.KeyPlayer:
                        description = "Key Player";
                        break;
                    case Nomination.Motivator:
                        description = "Motivator";
                        break;
                    case Nomination.Funny:
                        description = "Funny";
                        break;
                }

                return description;
            }
        }
    }
}
