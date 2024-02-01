﻿using exercise.webapi.Models.DatabaseModels;

namespace exercise.webapi.Models.DataTransfer.Books
{
    public class BookDTO(int Id, string Title, Author Author, Publisher publisher)
    {
        public int Id { get; set; } = Id;
        public string Title { get; set; } = Title;

        public AuthorInBookDTO Author { get; set; } = new AuthorInBookDTO(Author.Id, Author.FirstName, Author.LastName, Author.Email);

        public PublisherInBookDTO publisher { get; set; } = new PublisherInBookDTO(publisher.Id, publisher.Name);
    }
}