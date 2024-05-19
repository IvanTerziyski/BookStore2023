using BookStore.Models.Requests;
using BookStore.Models.Responses;

namespace BookStore.BL.Interfaces
{
    public interface ILibraryService
    {
        Task<GetAllBookByAuthorResponse?>
            GetAllBookByAuthorAfterReleaseDate(GetAllBookByAuthorRequest request);

        public Task<int> CheckBookCount(int input);

    }
}