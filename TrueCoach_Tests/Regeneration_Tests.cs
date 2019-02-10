using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TrueCoach.Models;


namespace TrueCoach_Tests
{
    public class Regeneration_Tests
    {
        [Fact]
        public void CanGetRegenerationID()
        {
            Regeneration regeneration = new Regeneration();
            regeneration.ID = 1;
            Assert.Equal(1, regeneration.ID);
        }

        [Fact]
        public void CanSetRegenerationID()
        {
            Regeneration regeneration = new Regeneration();
            regeneration.ID = 1;
            regeneration.ID = 2;
            Assert.Equal(2, regeneration.ID);
        }
        [Fact]
        public void CanGetRegenerationRegenerationID()
        {
            Regeneration regeneration = new Regeneration();
            regeneration.RegenerationID = 1;
            Assert.Equal(1, regeneration.RegenerationID);
        }

        [Fact]
        public void CanSetRegenerationRegenerationID()
        {
            Regeneration regeneration = new Regeneration();
            regeneration.RegenerationID = 1;
            regeneration.RegenerationID = 2;
            Assert.Equal(2, regeneration.RegenerationID);
        }

        [Fact]
        public void CanGetRegenerationRegenerationSteps()
        {
            Regeneration regeneration = new Regeneration();
            regeneration.RegenerationSteps = "Yes";
            Assert.Equal("Yes", regeneration.RegenerationSteps);
        }

        [Fact]
        public void CanSetRegenerationRegenerationSteps()
        {
            Regeneration regeneration = new Regeneration();
            regeneration.RegenerationSteps = "No";
            regeneration.RegenerationSteps = "Yes";
            Assert.Equal("Yes", regeneration.RegenerationSteps);
        }
    }
}
