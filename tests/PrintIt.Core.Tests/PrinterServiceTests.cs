﻿using System;
using FluentAssertions;
using Xunit;

namespace PrintIt.Core.Tests
{
    public sealed class PrinterServiceTests
    {
        [Fact]
        public void GetInstalledPrinters_ShouldReturnSomething()
        {
            // Arrange
            var printerService = new PrinterService();

            // Act
            string[] installedPrinters = printerService.GetInstalledPrinters();

            // Assert
            installedPrinters.Should().HaveCountGreaterOrEqualTo(1);
        }
    }
}