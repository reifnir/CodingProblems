using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalCoverageOfSegmentsOnALine =
    CodingProblems.Implementation.Codility.y2015.TotalCoverageOfSegmentsOnALine.Solution;

namespace CodingProblems.Tests.Codility.y2015
{
    [TestFixture]
    public class TotalCoverageOfSegmentsOnALineTests
    {
        [Test]
        public void Example1()
        {
            var segments = new List<Segment>()
            {
                new Segment(1, 5),
                new Segment(2, 3),
                new Segment(4, 6)
            };
            var query = TotalCoverageOfSegmentsOnALine.GetQuery();

            var expected = 5;
            var actual = ExecuteQuery(segments, query);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Example2()
        {
            var segments = new List<Segment>()
            {
                new Segment(1, 5),
                new Segment(2, 6),
                new Segment(10, 12)
            };
            var query = TotalCoverageOfSegmentsOnALine.GetQuery();

            var expected = 7;
            var actual = ExecuteQuery(segments, query);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Example3()
        {
            var segments = new List<Segment>()
            {
                new Segment(1, 5),
                new Segment(2, 3),
                new Segment(2, 4),
                new Segment(4, 6),
                new Segment(5, 7),
                new Segment(7, 9),
                new Segment(10, 11)
            };
            var query = TotalCoverageOfSegmentsOnALine.GetQuery();

            var expected = 9;
            var actual = ExecuteQuery(segments, query);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Example4()
        {
            var segments = new List<Segment>()
            {
                new Segment(0, 1),
                new Segment(0, 2),
                new Segment(4, 6),
                new Segment(8, 11)
            };
            var query = TotalCoverageOfSegmentsOnALine.GetQuery();

            var expected = 7;
            var actual = ExecuteQuery(segments, query);

            Assert.AreEqual(expected, actual);
        }

        private Int64 ExecuteQuery(List<Segment> segments, string query)
        {
            Int64 result;
            using (var conn = CreateDb(segments))
            using (var command = conn.CreateCommand())
            {
                command.CommandText = query;
                result = (Int64)command.ExecuteScalar();
            }
            return result;
        }


        private struct Segment
        {
            public int l;
            public int r;

            public Segment(int left, int right)
            {
                if (left > right)
                    throw new ArgumentException(string.Format("left({0}) must be <= right({1}).", left, right));
                
                l = left;
                r = right;
            }
        }
        private const string CREATE_TABLE =
            "create table segments (" +
            "   l integer not null," +
            "   r integer not null," +
            "   check(l <= r)," +
            "   unique(l,r)" +
            ");";
        private static SQLiteConnection CreateDb(List<Segment> segments)
        {
            var connection = new SQLiteConnection("Data Source=:memory:;Version=3;New=True;");
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = CREATE_TABLE;
                command.ExecuteNonQuery();
            }

            segments.ForEach(x => InsertSegment(connection, x));

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) [count] FROM segments;";
                var result = command.ExecuteScalar();
                Int64 typedResult = (Int64)result;

                //This is true if we haven't messed up, or setup SQLite incorrectly
                Assert.AreEqual(segments.Count, typedResult);
            }

            return connection;
        }

        private static void InsertSegment(SQLiteConnection connection, Segment segment)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = string.Format("INSERT INTO segments (l, r) VALUES ({0}, {1});", segment.l, segment.r);
                var result = command.ExecuteNonQuery();
            }
        }
    }
}
