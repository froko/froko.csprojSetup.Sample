//-------------------------------------------------------------------------------
// <copyright file="StringExtensionsTest.cs" company="frokonet.ch">
//   Copyright (c) 2016
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace MyLibrary
{
    using FluentAssertions;

    using Xunit;

    public class StringExtensionsTest
    {
        [Fact]
        public void ShouldCapitalizeFirstLetterOfEachWord()
        {
            "lorem ipsum dolor sit amet".CapitalizeFirstLetter().Should().Be("Lorem Ipsum Dolor Sit Amet");
        }

        [Fact]
        public void CapitalizeFirstLetterReturnsEmptyText_WhenEmptyTextIsGiven()
        {
            string.Empty.CapitalizeFirstLetter().Should().Be(string.Empty);
        }

        [Fact]
        public void CapitalizeFirstLetterReturnsEmptyText_WhenNullIsGiven()
        {
            ((string)null).CapitalizeFirstLetter().Should().Be(string.Empty);
        }
    }
}
