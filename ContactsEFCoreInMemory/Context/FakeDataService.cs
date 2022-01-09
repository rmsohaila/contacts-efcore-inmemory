﻿namespace ContactsEFCoreInMemory.Context;

public class FakeDataService<T> : IFakeDataGenerator<T> where T : class, IPrimaryKey, new()
{
    /// <summary>
    /// Generates a collection of type T based on the properties in T
    /// </summary>
    /// <returns>List<T></returns>
    public List<T> Collection() => GenFu.GenFu.ListOf<T>();

    /// <summary>
    /// Generates the collection of type T of size = length 
    /// </summary>
    /// <param name="length">The size of the collection to be passed</param>
    /// <returns>A collection of type T based on the length passed</returns>
    public List<T> Collection(int length)
    {
        var id = 1;
        GenFu.GenFu.Configure<T>()
            .Fill(p => p.Id, () => id++);

        return GenFu.GenFu.ListOf<T>(length);
    }

    /// <summary>
    /// Generates an object of type T with data
    /// </summary>
    /// <returns>T with data based on the properties in T</returns>
    public T Instance() => GenFu.GenFu.New<T>();
}
