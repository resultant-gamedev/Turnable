﻿using System;
using System.IO;
using NUnit.Framework;
using Turnable.Tiled;
using System.Xml.Linq;

namespace Tests.Tiled
{
    [TestFixture]
    public class PropertyTests
    {
        [Test]
        public void ParameterlessConstructor_Exists()
        {
            var property = new Property();

            Assert.That(property.Name, Is.Null);
            Assert.That(property.Value, Is.Null);
            Assert.That(property.Type, Is.EqualTo(PropertyType.String));
        }
    }
}
