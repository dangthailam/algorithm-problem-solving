using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class UpdateMatrixTests
    {
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        [TestMethod()]
        public void SolveTest()
        {
            var user = new User
            {
                Id = 1,
                Name = "test"
            };

            var users1 = new List<User>();

            users1.Add(user);

            var users2 = new List<User>();

            users2.Add(user);

            user.Name = "test2";

            var mat = new int[3][] {
                new int[] {0, 0, 1, 1 },
                new int[] {0, 1, 0, 1 },
                new int[] {1, 1, 1, 0 }
            };

            var result = new UpdateMatrix().Solve(mat);
        }
    }
}