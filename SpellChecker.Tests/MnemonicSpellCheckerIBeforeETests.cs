﻿using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using SpellChecker.Contracts;
using SpellChecker.Core;

namespace SpellChecker.Tests
{

    [TestClass]
    public class MnemonicSpellCheckerIBeforeETests
    {

        ISpellChecker spellChecker;

        [TestInitialize]
        public void TestFixtureSetUp()
        {
            spellChecker = new MnemonicSpellCheckerIBeforeE();
        }

        [TestMethod]
        public void Check_Word_That_Contains_I_Before_E_Is_Spelled_Correctly()
        {
            spellChecker = new MnemonicSpellCheckerIBeforeE();
            var asyncTask = spellChecker.CheckAsync("believe");
            Assert.IsTrue(asyncTask.Result);
        }

        [TestMethod]
        public void Check_Word_That_Contains_I_Before_E_Is_Spelled_Incorrectly()
        {
            spellChecker = new MnemonicSpellCheckerIBeforeE();
            var asyncTask = spellChecker.CheckAsync("science");
            Assert.IsFalse(asyncTask.Result);
        }

    }

}
