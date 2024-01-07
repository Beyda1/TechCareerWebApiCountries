using Microsoft.AspNetCore.Mvc;

namespace TechCareerWebApiCountries.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Countries : ControllerBase
    {
        [HttpGet]
        public string[] Get()
        {
            string[] countries = new string[] { "USA", "Canada", "Mexico", "Argentina", "Australia", "Brazil", "France", "Germany", "Türkiye", "Russia", "China", "South Korea", "Japan", "Italy", "Iceland", "Sweden", "Norway", "Switzerland", "Denmark", "Finland" };
            return countries;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            string[] countries = new string[] { "USA", "Canada", "Mexico", "Argentina", "Australia", "Brazil", "France", "Germany", "Türkiye", "Russia", "China", "South Korea", "Japan", "Italy", "Iceland", "Sweden", "Norway", "Switzerland", "Denmark", "Finland" };

            // Check if the id is valid
            if (id < 0 || id >= countries.Length)
            {
                return "Invalid ID";
            }
            else
            {
                return countries[id];
            }
        }
    }
}
