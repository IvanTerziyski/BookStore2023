using BookStore.Models.Requests;
using BookStore.Models.Responses;

namespace BookStore.BL.Interfaces
{
    public interface ILibraryService
    {
        GetAllBookByAuthorResponse
            GetAllBookByAuthorAfterReleaseDate(GetAllBookByAuthorRequest request);
    }
}