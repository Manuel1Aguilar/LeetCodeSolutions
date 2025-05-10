namespace LeetCodeSolutions;
/*
 There is a dungeon with n x m rooms arranged as a grid.

You are given a 2D array moveTime of size n x m, where moveTime[i][j] represents the minimum time in seconds when you can start moving to that room. You start from the room (0, 0) at time t = 0 and can move to an adjacent room. Moving between adjacent rooms takes _one_ second for one move and _two_ seconds for the next, alternating between the two.

Return the minimum time to reach the room (n - 1, m - 1).

Two rooms are adjacent if they share a common wall, either horizontally or vertically.
*/
public static class MinimumTimeToReachLastRoomII {
    private static int MinTimeToReach(int[][] moveTime) {
        int n = moveTime.Length, m = moveTime[0].Length, INF = int.MaxValue;
        int[,] dist = new int[n, m];
        
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                dist[i, j] = INF;

        var pq = new PriorityQueue<(int r, int c, int t, bool es), int>();
        pq.Enqueue((0, 0, 0, false), 0);
        dist[0, 0] = 0;

        int[] dr = [1, -1, 0, 0];
        int[] dc = [0, 0, 1, -1];

        while (pq.Count > 0) {
            var (r, c, t, es) = pq.Dequeue();
            if (dist[r, c] != t) {
                continue;
            }

            if (r == n - 1 && c == m - 1) {
                return t;
            }

            for (int d = 0; d < 4; d++) {
                int nr = r + dr[d], nc = c + dc[d];
                if (nr < 0 || nr >= n || nc < 0 || nc >= m) {
                    continue;
                }
                int toAdd = es ? 2 : 1;
                int newTime = Math.Max(moveTime[nr][nc], t) + toAdd;
                if (newTime < dist[nr, nc]) {
                    dist[nr, nc] = newTime;
                    pq.Enqueue((nr, nc, newTime, !es), newTime);
                }
            }
        }
        return -1;
    }

    public static void CallSolution() {
        int [][] input;
        int output;
        Console.WriteLine("Solution for problem 3341. Find Minimum Time to Reach Last Room I");

        input = [[0,4],[4,4]];
        output = MinTimeToReach(input);
        Console.WriteLine($"Input: {string.Join(',', input.Select(x => "[" + string.Join(',', x) + "]\n"))}; \nOutput: {output}");

        input = [[94,79, 62, 27, 69, 84],[6,32,11,82,42,30]];
        output = MinTimeToReach(input);
        Console.WriteLine($"Input: {string.Join(',', input.Select(x => "[" + string.Join(',', x) + "]\n"))}; \nOutput: {output}");

        input = [[275,289,370,277,369,258,85],[78,231,82,428,339,489,214],[440,480,166,222,134,492,146],[3,122,16,218,500,166,225]];
        output = MinTimeToReach(input);
        Console.WriteLine($"Input: {string.Join(',', input.Select(x => "[" + string.Join(',', x) + "]\n"))}; \nOutput: {output}");

        input = [[0, 0, 0, 0],[0, 0, 0, 0]];
        output = MinTimeToReach(input);
        Console.WriteLine($"Input: {string.Join(',', input.Select(x => "[" + string.Join(',', x) + "]\n"))}; \nOutput: {output}");
    }
}
