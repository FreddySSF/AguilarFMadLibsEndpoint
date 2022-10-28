// Fernando Aguilar
// 10-26-22
// Mad Libs Endpoint
// This program takes mini challenge 5 and converts it into an API program. It will
// take in the inputs for each of the variables asked of the user and outputs them into Postman
// as a madlib short story that includes the users inputs.
// Peer Reviewed By: Christopher Prado, this code is adaquetly organized and outputs a quite creative story. Try at your own risk but I surely reccomend >:)


using Microsoft.AspNetCore.Mvc;

namespace AguilarFMadLibsEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibsController : ControllerBase
{
    [HttpGet]
    [Route("userInput/{myName}/{friendName}/{favPlace}/{adjective}/{superHero1}/{superhero2}/{evilVillain}/{power1}/{power2}/{amusementPark}")]

    public string userInput(string myName, string friendName, string favPlace, string adjective, string superHero1, string superHero2, string evilVillain, string power1, string power2, string amusementPark)
    {
        return $" Our story unfolds with {myName} and {friendName}. They were hanging out at {favPlace} when suddenly a {adjective} explosion could be heard from outside. {superHero1}, and {superHero2} enter {favPlace} and tell everyone to evacuate immediately! The two friends follow suite but are stopped by the two heroes. The heroes tell the pair that they have been chosen to join them in fighting {evilVillain}, the source of the chaos. They offer the pair a set of rings, each containing a superpower! {myName} chooses {power1} and {friendName} chooses {power2}. Together they join forces and fight against {evilVillain}! After an epic battle, the pair of friends and our two heroes have saved the day and go to {amusementPark} to celebrate a job well done!";
    }
}
