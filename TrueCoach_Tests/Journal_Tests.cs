using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TrueCoach.Models;

namespace TrueCoach_Tests
{
    public class Journal_Tests
    {
        [Fact]
        public void CanGetJournalID()
        {
            Journal journal = new Journal();
            journal.ID = 1;
            Assert.Equal(1, journal.ID);
        }

        [Fact]
        public void CanSetJournalID()
        {
            Journal journal = new Journal();
            journal.ID = 1;
            journal.ID = 2;
            Assert.Equal(2, journal.ID);
        }

        [Fact]
        public void CanGetJournalProfileID()
        {
            Journal journal = new Journal();
            journal.ProfileID = 1;
            Assert.Equal(1, journal.ProfileID);
        }

        [Fact]
        public void CanSetJournalProfileID()
        {
            Journal journal = new Journal();
            journal.ProfileID = 1;
            journal.ProfileID = 2;
            Assert.Equal(2, journal.ProfileID);
        }

        [Fact]
        public void CanGetJournalEntry()
        {
            Journal journal = new Journal();
            journal.Entry = "Yes";
            Assert.Equal("Yes", journal.Entry);
        }

        [Fact]
        public void CanSetJournalEntry()
        {
            Journal journal = new Journal();
            journal.Entry = "No";
            journal.Entry = "Yes";
            Assert.Equal("Yes", journal.Entry);
        }
    }
}
