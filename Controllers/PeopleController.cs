using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeopleGroupsAPI.Models;

namespace PeopleGroupsAPI.Controllers
{
    public class PeopleController : Controller {        
        
    public List<List<Person>> Index() {
        return 
            new List<List<Person>> {
                new List<Person> {
                new Person() { Name = "Joe"},
                new Person() { Name = "Sue"},
                new Person() { Name = "Bob"},
                new Person() { Name = "Diane"},
                new Person() { Name = "Jack"}
            },
            new List<Person>() {
                new Person() { Name = "Mary"},
                new Person() { Name = "George"},
                new Person() { Name = "Harry"},
            },
            new List<Person>() {
                new Person() { Name = "Neil"},
            }
            };
        }
    }
}
