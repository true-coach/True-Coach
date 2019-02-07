using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TrueCoach.Models;

namespace TrueCoach_Tests
{
    public class User_Tests
    {
        [Fact]
        public void CanGetUserID()
        {
            User user = new User();
            user.ID = 1;
            Assert.Equal(1, user.ID);   
        }
        [Fact]
        public void CanSerUserID()
        {
            User user = new User();
            user.ID = 1;
            user.ID = 2;
            Assert.Equal(2, user.ID);
        }

        [Fact]
        public void CanGetUserUserName()
        {
            User user = new User();
            user.UserName = "Name";
            Assert.Equal("Name", user.UserName);
        }
        [Fact]
        public void CanSerUserUserName()
        {
            User user = new User();
            user.UserName = "First";
            user.UserName = "Name";
            Assert.Equal("Name", user.UserName);
        }
    }
}
