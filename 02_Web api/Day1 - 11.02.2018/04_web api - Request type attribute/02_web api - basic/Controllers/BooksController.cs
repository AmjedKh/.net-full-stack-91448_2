﻿using _02_web_api___basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _02_web_api___basic.Controllers
{
    public class BooksController : ApiController
    {

        //returns status code 204
        [HttpGet]
        public void NoBook(int minNumOfPages)
        {
        }


        [HttpGet]
        public HttpResponseMessage IsInSale(int num)
        {
            return new HttpResponseMessage(HttpStatusCode.NotFound);
        }

        [HttpGet]
        public IEnumerable<Book> Min(int minNumOfPages)
        {
            return Library.books.Where(book => book.volumeInfo.pageCount >= minNumOfPages);
        }

        [HttpGet]
        public IEnumerable<Book> Max(int maxNumOfPages)
        {
            return Library.books.Where(book=>book.volumeInfo.pageCount<=maxNumOfPages);
        }
        
        public Book GetFirst()
        {
            return Library.books.FirstOrDefault();
        }

      
    }
}
