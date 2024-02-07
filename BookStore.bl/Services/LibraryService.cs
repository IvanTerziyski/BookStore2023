﻿using BookStore.BL.Interfaces;
using BookStore.Models.Models;
using BookStore.Models.Requests;
using BookStore.Models.Responses;

namespace BookStore.BL.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;
        public LibraryService(IAuthorService authorService, IBookService bookService)
        {
            _authorService = authorService;
            _bookService = bookService;
        }

        public int CheckBookCount(int input)
        {
            if (input < 0) return 0;
            var bookCount = _bookService.GetAllBooks();
            return bookCount.Count + input;
        }

        public GetAllBookByAuthorResponse 
            GetAllBookByAuthorAfterReleaseDate(GetAllBookByAuthorRequest request)
        {
            var response = new GetAllBookByAuthorResponse();
            response.Author = _authorService.GetAuthor(request.AuthorId);
            response.Books = _bookService.GetAllBooksByAuthorAfterReleaseDate(request.AuthorId, request.DateAfter);
            return response;
        }
    }
}
