namespace ConsoleApp.Problems.LeetCode.RankTeamsByVotes;

public class RankTeamsByVotesSolution
{
    public string Solve(string[] votes)
    {
        if (votes.Length == 1) return votes.First();
        
        Dictionary<char, int[]> teamsVotes = new Dictionary<char, int[]>();
        var teamCount = votes.First().Length;
        foreach (var team in votes.First()) {
            teamsVotes.Add(team, new int[teamCount]);
        }

        for (var i = 0; i < votes.Length; i++) {
            var vote = votes[i];
            for (var j = 0; j < vote.Length; j++) {
                teamsVotes[vote[j]][j]++;
            }
        }

        var sorted = teamsVotes.AsEnumerable().OrderBy(
            team => team, new VoteComparer()
        );
        
        var result = "";
        foreach (var team in sorted) {
            result += team.Key;
        }
        
        return result;
    }
    
    private class VoteComparer : IComparer<KeyValuePair<char, int[]>> {
        public int Compare(KeyValuePair<char, int[]> x, KeyValuePair<char, int[]> y) {
            for (var i = 0; i < x.Value.Length; i++) {
                if (x.Value[i] > y.Value[i]) return -1;
                if (x.Value[i] < y.Value[i]) return 1;
            }
            
            return y.Key > x.Key ? -1 : 1;
        }
    }
}