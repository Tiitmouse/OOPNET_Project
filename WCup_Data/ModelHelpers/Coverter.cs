using System.Text.Json;
using WCup_Data.Models;
using WCup_Data.Models.Enums;

namespace WCup_Data.ModelHelpers;

public class Coverter
{
    internal static class Converter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                TypeOfEventConverter.Singleton,
                PositionConverter.Singleton,
                TacticsConverter.Singleton,
                StageNameConverter.Singleton,
                StatusConverter.Singleton,
                TimeConverter.Singleton,
                DescriptionConverter.Singleton,
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }
}