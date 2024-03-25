using System.Text.Json;
using System.Text.Json.Serialization;

namespace WCup_Data.Models.Enums;

public enum TypeOfEvent
{
    Goal,
    GoalOwn,
    GoalPenalty,
    RedCard,
    SubstitutionIn,
    SubstitutionOut,
    YellowCard,
    YellowCardSecond
};

