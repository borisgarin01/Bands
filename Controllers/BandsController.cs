using Microsoft.AspNetCore.Mvc;

namespace NgSight.Controllers;

[ApiController]
[Route("[controller]")]
public class BandsController : ControllerBase
{
    private readonly ILogger<BandsController> _logger;

    public BandsController(ILogger<BandsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Band> Get()
    {
        var hundredGreatestMetalAlbum = new Album { Title = "100 Greatest Metal" };
        var afterlifeAlbum = new Album { Title = "Afterlife" };
        var almostEasyAlbum = new Album { Title = "Almost Easy" };
        var avengedSevenfoldAlbum = new Album { Title = "Avenged Sevenfold" };
        var beastAndTheHarlotAlbum = new Album { Title = "Beast and the Harlot" };
        var blackReignAlbum = new Album { Title = "Black Reign" };
        var cityOfEvilAlbum = new Album { Title = "City of Evil" };
        var coveredRevolutionInSoundWarnerBrosRecordsAlbum = new Album { Title = "Covered, A Revolution In Sound: Warner Bros. Records" };
        var crossroadsAlbum = new Album { Title = "Crossroards" };
        var diamondsInTheRoughAlbum = new Album { Title = "Diamonds in the Rough" };
        var hailToTheKingAlbum = new Album { Title = "Hail to the King" };
        var hailToTheKingDeathbatAlbum = new Album { Title = "Hail To The King: Deathbat" };
        var malaguenaSalerosaAlbum = new Album { Title = "Malagueña Salerosa" };
        var nightmareAlbum = new Album { Title = "Nightmare" };
        var soundingTheSeventhTrumpetAlbum = new Album { Title = "Sounding The Seventh Trumpet" };
        var theStageAlbum = new Album { Title = "The Stage" };
        var wakingTheFallenAlbum = new Album { Title = "Waking The Fallen" };
        var wakingTheFallenResurrectedAlbum = new Album { Title = "Waking The Fallen: Resurrected" };
        var welcomeToTheFamilyAlbum = new Album { Title = "Welcome to the Family" };

        var songs = new Song[]
        {
            new Song{Title="Hail to the King", Album=hundredGreatestMetalAlbum},
            new Song{Title="Nightmare", Album=hundredGreatestMetalAlbum },
            new Song{Title="Afterlife", Album=afterlifeAlbum},
            new Song{Title="Critical Acclaim", Album=afterlifeAlbum},
            new Song{Title="Beast and the Harlot", Album=afterlifeAlbum },
            new Song{Title="Almost Easy", Album=almostEasyAlbum},
            new Song{Title="Walk", Album=almostEasyAlbum},
            new Song{Title="Scream", Album=avengedSevenfoldAlbum},
            new Song{Title="Gunslinger", Album=avengedSevenfoldAlbum},
            new Song{Title="Unbound (The Wild Ride)", Album=avengedSevenfoldAlbum },
            new Song{Title="Brompton Cocktail", Album=avengedSevenfoldAlbum},
            new Song{Title="Lost", Album=avengedSevenfoldAlbum},
            new Song{Title="A Little Piece of Headen", Album=avengedSevenfoldAlbum},
            new Song{Title="Dear God", Album=avengedSevenfoldAlbum},
            new Song{Title="Bat Country", Album=avengedSevenfoldAlbum},
            new Song{Title="Scream", Album=avengedSevenfoldAlbum},
            new Song{Title="Brompton Cocktail", Album=avengedSevenfoldAlbum},
            new Song{Title="Lost", Album=avengedSevenfoldAlbum},
            new Song{Title="Dear God", Album=avengedSevenfoldAlbum},
            new Song{Title="Burn It Down", Album=beastAndTheHarlotAlbum},
            new Song{Title="Mad Hatter", Album=blackReignAlbum},
            new Song{Title="Carry On", Album=blackReignAlbum},
            new Song{Title="Not Ready to Die", Album=blackReignAlbum },
            new Song{Title="Jade Helm", Album=blackReignAlbum},
            new Song{Title="Blinded in Chains", Album=cityOfEvilAlbum},
            new Song{Title="Trashed and Scattered",Album=cityOfEvilAlbum},
            new Song{Title="Seize the Day", Album=cityOfEvilAlbum},
            new Song{Title="Sidewinder", Album=cityOfEvilAlbum},
            new Song{Title="The Wicked End", Album=cityOfEvilAlbum},
            new Song{Title="Strenth of the World", Album=cityOfEvilAlbum},
            new Song{Title="Betrayed", Album=cityOfEvilAlbum},
            new Song{Title="M.I.A.", Album=cityOfEvilAlbum},
            new Song{Title="Paranoid", Album=coveredRevolutionInSoundWarnerBrosRecordsAlbum},
            new Song{Title="Crossroads", Album=crossroadsAlbum},
            new Song{Title="Demons", Album=diamondsInTheRoughAlbum},
            new Song{Title="Girl I Know", Album=diamondsInTheRoughAlbum},
            new Song{Title="Flash of the Blade", Album=diamondsInTheRoughAlbum},
            new Song{Title="Until the End", Album=diamondsInTheRoughAlbum},
            new Song{Title="Tension", Album=diamondsInTheRoughAlbum},
            new Song{Title="Walk", Album=diamondsInTheRoughAlbum},
            new Song{Title="The Fight", Album=diamondsInTheRoughAlbum},
            new Song{Title="Dancing Dead", Album=diamondsInTheRoughAlbum},
            new Song{Title="St.James",Album=diamondsInTheRoughAlbum},
            new Song{Title="Set Me Free", Album=diamondsInTheRoughAlbum},
            new Song{Title="4:00 AM",Album=welcomeToTheFamilyAlbum},
            new Song{Title="Lost It All", Album=diamondsInTheRoughAlbum},
            new Song{Title="Hail to the King", Album=hailToTheKingAlbum},
            new Song{Title="Doing Time", Album=hailToTheKingAlbum},
            new Song{Title="This Means War", Album=hailToTheKingAlbum},
            new Song{Title="Requiem", Album=hailToTheKingAlbum},
            new Song{Title="Crimson Day", Album=hailToTheKingAlbum},
            new Song{Title="Heretic", Album=hailToTheKingAlbum},
            new Song{Title="Coming Home", Album=hailToTheKingAlbum},
            new Song{Title="Planets", Album=hailToTheKingAlbum},
            new Song{Title="Acid Rain", Album=hailToTheKingAlbum},
            new Song{Title="St.James",Album=hailToTheKingAlbum},
            new Song{Title="Shepherd of Fire",Album=hailToTheKingAlbum},
            new Song{Title="Hail to the King", Album=hailToTheKingAlbum},
            new Song{Title="Doing Time", Album=hailToTheKingAlbum},
            new Song{Title="This Means War", Album=hailToTheKingAlbum},
            new Song{Title="Requiem", Album=hailToTheKingAlbum},
            new Song{Title="Crimson Day", Album=hailToTheKingAlbum},
            new Song{Title="Heretic", Album=hailToTheKingAlbum},
            new Song{Title="Coming Home", Album=hailToTheKingAlbum},
            new Song{Title="Planets", Album=hailToTheKingAlbum},
            new Song{Title="Acid Rain", Album=hailToTheKingAlbum},
            new Song{Title="Andronikos Theme", Album=hailToTheKingDeathbatAlbum},
            new Song{Title="Nightmare Theme", Album=hailToTheKingDeathbatAlbum},
            new Song{Title="Unholy Theme", Album=hailToTheKingDeathbatAlbum},
            new Song{Title="Bat Country Theme", Album=hailToTheKingDeathbatAlbum},
            new Song{Title="Babylon Theme", Album=hailToTheKingDeathbatAlbum},
            new Song{Title="Afterlife Theme", Album=hailToTheKingDeathbatAlbum},
            new Song{Title="Heaven Theme", Album=hailToTheKingDeathbatAlbum},
            new Song{Title="Wicked End Theme", Album=hailToTheKingDeathbatAlbum},
            new Song{Title="Warrior Theme", Album=hailToTheKingDeathbatAlbum},
            new Song{Title="Malaguena Salerosa", Album=malaguenaSalerosaAlbum},
            new Song{Title="Nightmare", Album=nightmareAlbum},
            new Song{Title="Welcome to the Family", Album=nightmareAlbum},
            new Song{Title="Danger Line", Album=nightmareAlbum},
            new Song{Title="Buried Alive", Album=nightmareAlbum},
            new Song{Title="Natural Burn Killer", Album=nightmareAlbum},
            new Song{Title="So Far Away", Album=nightmareAlbum},
            new Song{Title="God Hates Us", Album=nightmareAlbum},
            new Song{Title="Victim", Album=nightmareAlbum },
            new Song{Title="Tonight the World Dies", Album=nightmareAlbum},
            new Song{Title="Fiction", Album=nightmareAlbum},
            new Song{Title="Save Me", Album=nightmareAlbum},
            new Song{Title="Nightmare", Album=nightmareAlbum},
            new Song{Title="Welcome to the Family", Album=nightmareAlbum},
            new Song{Title="Danger Line", Album=nightmareAlbum},
            new Song{Title="Buried Alive", Album=nightmareAlbum},
            new Song{Title="Natural Born Killer", Album=nightmareAlbum},
            new Song{Title="So Far Away", Album=nightmareAlbum},
            new Song{Title="God Hates Us", Album=nightmareAlbum},
            new Song{Title="Victim", Album=nightmareAlbum},
            new Song{Title="Tonight the World Dies", Album=nightmareAlbum},
            new Song{Title="Fiction", Album=nightmareAlbum},
            new Song{Title="Save Me", Album=nightmareAlbum},
            new Song{Title="To End The Rapture", Album=soundingTheSeventhTrumpetAlbum},
            new Song{Title="Turn The Other Way", Album=soundingTheSeventhTrumpetAlbum},
            new Song{Title="Darkness Surrounding", Album=soundingTheSeventhTrumpetAlbum},
            new Song{Title="The Art of Subconscious Illusion", Album=soundingTheSeventhTrumpetAlbum},
            new Song{Title="We Come Out At Night", Album=soundingTheSeventhTrumpetAlbum},
            new Song{Title="Lips of Deceit", Album=soundingTheSeventhTrumpetAlbum},
            new Song{Title="Warmness on the Soul", Album=soundingTheSeventhTrumpetAlbum},
            new Song{Title="An Epic of Time Wasted", Album=soundingTheSeventhTrumpetAlbum},
            new Song{Title="Breaking Their Hold", Album=soundingTheSeventhTrumpetAlbum},
            new Song{Title="Forgotten Faces", Album=soundingTheSeventhTrumpetAlbum},
            new Song{Title="Thick and Thin", Album=soundingTheSeventhTrumpetAlbum},
            new Song{Title="Streets", Album=soundingTheSeventhTrumpetAlbum},
            new Song{Title="Shattered By Broken Dreams", Album=soundingTheSeventhTrumpetAlbum},
            new Song{Title="The Stage", Album=theStageAlbum},
            new Song{Title="Paradigm", Album=theStageAlbum},
            new Song{Title="Sunny Disposition", Album=theStageAlbum},
            new Song{Title="God Damn", Album=theStageAlbum},
            new Song{Title="Creating God", Album=theStageAlbum},
            new Song{Title="Angels", Album=theStageAlbum},
            new Song{Title="Simulation", Album=theStageAlbum},
            new Song{Title="Higher", Album=theStageAlbum},
            new Song{Title="Roman Sky", Album=theStageAlbum},
            new Song{Title="Fermi Paradox", Album=theStageAlbum},
            new Song{Title="Exist", Album=theStageAlbum},
            new Song{Title="Dose", Album=theStageAlbum},
            new Song{Title="Retrovertigo", Album=theStageAlbum},
            new Song{Title="Runaway", Album=theStageAlbum},
            new Song{Title="As Tears Go By", Album=theStageAlbum},
            new Song{Title="Wish You Were Here", Album=theStageAlbum},
            new Song{Title="God Only Knows", Album=theStageAlbum},
            new Song{Title="Waking the Fallen", Album=wakingTheFallenAlbum},
            new Song{Title="Unholy Confessions", Album=wakingTheFallenAlbum},
            new Song{Title="Chapter Four", Album=wakingTheFallenAlbum},
            new Song{Title="Remenissions", Album=wakingTheFallenAlbum},
            new Song{Title="Desecrate Through Reverence", Album=wakingTheFallenAlbum},
            new Song{Title="Eternal Rest", Album=wakingTheFallenAlbum},
            new Song{Title="Second Heartbeat", Album=wakingTheFallenAlbum},
            new Song{Title="Radiant Eclipse", Album=wakingTheFallenAlbum},
            new Song{Title="I Won't See You Tonight Part 1", Album=wakingTheFallenAlbum},
            new Song{Title="I Won't See You Tonight Part 2", Album=wakingTheFallenAlbum},
            new Song{Title="Clairvoyant Disease", Album=wakingTheFallenAlbum},
            new Song{Title="And All Things Will End", Album=wakingTheFallenAlbum},
            new Song{Title="Waking the Fallen: Resurrected", Album=wakingTheFallenResurrectedAlbum},
        };

        var bands = new Band[]
        {
            new Band
            {
                Name="Avenged Sevenfold",
                Songs=songs
            }
        };

        return bands;
    }
}

public class Band
{
    public string Name { get; set; }
    public Song[] Songs { get; set; }
}

public class Song
{
    public string Title { get; set; }
    public Album Album { get; set; }
}

public class Album
{
    public string Title { get; set; }
}
