namespace BuberBreakfast.Contracts.Breakfast;

public record UpsertBreakfastRequset(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet

);