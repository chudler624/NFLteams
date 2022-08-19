using Teams;

var team1 = new NFLTeam();

    team1.name = "Patriots";
    team1.location = "New England";
    team1.ranking = 1;
    team1.haveWonSuperBowl = true;
    team1.SuperBowlsWon = 6;

var team2 = new NFLTeam();

    team2.name = "Steelers";
    team2.location = "Pittsburg";
    team2.ranking = 2;
    team2.haveWonSuperBowl = true;
    team2.SuperBowlsWon = 6;

var team3 = new NFLTeam();

    team3.name = "Rams";
    team3.location = "Los Angeles";
    team3.ranking = 3;
    team3.haveWonSuperBowl = true;
    team3.SuperBowlsWon= 3;

var team4 = new NFLTeam();
    team4.name = "Cardinals";
    team4.location = "Arizona";
    team4.ranking = 24;
    team4.haveWonSuperBowl = false;
    team4.SuperBowlsWon = 0;



List<string> NFLteamList = new List<string>();
{ team1, team2, team3, team4}

    
    

foreach (var team in NFLteamList)
    Console.WriteLine();