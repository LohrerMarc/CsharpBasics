# Test Assertions
## FluentAssertions

FluentAssertions bietet eine Vielzahl von Assertions, die man verwenden kann, um den Zustand von Objekten, Werten und Sammlungen zu überprüfen. Hier sind einige der häufig verwendeten Assertionstypen:

``` ~~~csharp
// Objekt-Assertions
myObject.Should().Be(expectedObject);
myObject.Should().BeOfType<ExpectedType>();
myObject.Should().NotBeNull();
myObject.Should().BeAssignableTo<ExpectedType>();

// Wert-Assertions
myValue.Should().Be(expectedValue);
myValue.Should().BeInRange(minValue, maxValue);
myValue.Should().BePositive();
myValue.Should().BeNegative();
myValue.Should().BeApproximately(expectedValue, precision);

// String-Assertions
myString.Should().Be(expectedString);
myString.Should().BeNullOrEmpty();
myString.Should().Contain(expectedSubstring);
myString.Should().StartWith(expectedPrefix);
myString.Should().EndWith(expectedSuffix);
myString.Should().MatchRegex(regexPattern);

// Sammlungs-Assertions
myCollection.Should().BeEquivalentTo(expectedCollection);
myCollection.Should().HaveCount(expectedCount);
myCollection.Should().Contain(expectedElement);
myCollection.Should().ContainItemsAssignableTo<ExpectedType>();
myCollection.Should().BeInAscendingOrder();
myCollection.Should().BeInDescendingOrder();

// Exception-Assertions
Action action = () => methodThatThrows();
action.Should().Throw<ExpectedExceptionType>();
action.Should().ThrowExactly<ExpectedExceptionType>();
action.Should().NotThrow();

// Datum- und Zeit-Assertions
myDateTime.Should().Be(expectedDateTime);
myDateTime.Should().BeBefore(expectedDateTime);
myDateTime.Should().BeAfter(expectedDateTime);
myDateTime.Should().BeCloseTo(expectedDateTime, precision);

// Nullable-Assertions
myNullable.Should().HaveValue();
myNullable.Should().NotHaveValue();
```
For more details see here: https://fluentassertions.com/introduction

## MsTest
MSTest bietet eine Vielzahl von Assertions, die man verwenden kann, um den Zustand von Objekten, Werten und Sammlungen zu überprüfen. Hier sind einige der häufig verwendeten Assertionstypen:

```~~~csharp
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Allgemeine Assertions
Assert.AreEqual(expected, actual);
Assert.AreNotEqual(notExpected, actual);
Assert.IsTrue(condition);
Assert.IsFalse(condition);
Assert.IsNull(object);
Assert.IsNotNull(object);

// String-Assertions
StringAssert.Contains(actualString, expectedSubstring);
StringAssert.StartsWith(actualString, expectedPrefix);
StringAssert.EndsWith(actualString, expectedSuffix);
StringAssert.Matches(actualString, regexPattern);
StringAssert.DoesNotMatch(actualString, regexPattern);

// Sammlungs-Assertions
CollectionAssert.AreEqual(expectedCollection, actualCollection);
CollectionAssert.AreNotEqual(notExpectedCollection, actualCollection);
CollectionAssert.Contains(collection, element);
CollectionAssert.DoesNotContain(collection, element);
CollectionAssert.AllItemsAreNotNull(collection);
CollectionAssert.AllItemsAreUnique(collection);

// Exception-Assertions
Assert.ThrowsException<ExpectedExceptionType>(() => methodThatThrows());
Assert.ThrowsException<ExpectedExceptionType>(() => methodThatThrows(), "A custom message");
Assert.ThrowsExceptionAsync<ExpectedExceptionType>(async () => await methodThatThrowsAsync());

// Datum- und Zeit-Assertions
// MSTest hat keine speziellen Datum- und Zeit-Assertions, aber man kann die allgemeinen Assertions verwenden
Assert.AreEqual(expectedDateTime, actualDateTime);
Assert.AreNotEqual(notExpectedDateTime, actualDateTime);

// Nullable-Assertions
// MSTest hat keine speziellen Nullable-Assertions, aber man kann die allgemeinen Assertions verwenden
Assert.IsNotNull(nullableObject);
Assert.IsNull(nullableObject);
```
