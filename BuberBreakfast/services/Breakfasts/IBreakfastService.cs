namespace BuberBreakfast.Services.Breakfasts;
using BuberBreakfast.Models;
using ErrorOr;

public interface IBreakfastService
{
    ErrorOr<Created> CreateBreakfast(Breakfast breakfast);
    ErrorOr<Deleted> DeleteBreakfast(Guid id);
    ErrorOr<Breakfast> GetBreakfast(Guid id);
    ErrorOr<UpsertedBreakfastResult> UpsertBreakfast(Breakfast breakfast);
}