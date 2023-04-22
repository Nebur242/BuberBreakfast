using ErrorOr;
public static class Errors
{
    public static class Breakfast
    {
        public static Error InvalidDescription => Error.Validation(
            code: "Breakfast.InvalidDescription",
            description: $"Breakfast description must be at least {BuberBreakfast.Models.Breakfast.MinDescriptionLength} character long and at most {BuberBreakfast.Models.Breakfast.MaxDescriptionLength} characters long."
        );

        public static Error InvalidName => Error.Validation(
            code: "Breakfast.InvalidName",
            description: $"Breakfast name must be at least {BuberBreakfast.Models.Breakfast.MinNameLength} character long and at most {BuberBreakfast.Models.Breakfast.MaxNameLength} characters long."
        );
        public static Error NotFound => Error.NotFound(
            code: "Breakfast.NotFound",
            description: "Breakfast Not Found"
        );
    }
}