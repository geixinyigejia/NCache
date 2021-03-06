﻿// ==++==
//Copyright(c) Microsoft Corporation

//Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
//associated documentation files (the "Software"), to deal in the Software without restriction, 
//including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
//and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, 
//subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all copies or substantial
//portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
//NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
//IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
//WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
//SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ==--==

using System;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

namespace System.DirectoryServices
{
    //
    // Summary:
    //     The System.DirectoryServices.PropertyCollection class contains the properties
    //     of a System.DirectoryServices.DirectoryEntry.
    //[DefaultMember("Item")]
    public class PropertyCollection : IDictionary, ICollection, IEnumerable
    {
        //
        // Summary:
        //     Gets the specified property.
        //
        // Parameters:
        //   propertyName:
        //     The name of the property to retrieve.
        //
        // Returns:
        //     The value of the specified property.
        public PropertyValueCollection this[string propertyName] { get { throw new NotImplementedException(); } }
        public object this[object key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //
        // Summary:
        //     Gets the number of properties in this collection.
        //
        // Returns:
        //     The number of properties in this collection.
        //
        // Exceptions:
        //   T:System.Runtime.InteropServices.COMException:
        //     An error occurred during the call to the underlying interface.
        //
        //   T:System.NotSupportedException:
        //     The directory cannot report the number of properties.
        public int Count { get; }
        //
        // Summary:
        //     Gets the names of the properties in this collection.
        //
        // Returns:
        //     An System.Collections.ICollection object that contains the names of the properties
        //     in this collection.
        public ICollection PropertyNames { get; }
        //
        // Summary:
        //     Gets the values of the properties in this collection.
        //
        // Returns:
        //     An System.Collections.ICollection that contains the values of the properties
        //     in this collection.
        public ICollection Values { get; }

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsFixedSize => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public ICollection Keys => throw new NotImplementedException();

        public void Add(object key, object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Determines whether the specified property is in this collection.
        //
        // Parameters:
        //   propertyName:
        //     The name of the property to find.
        //
        // Returns:
        //     The return value is true if the specified property belongs to this collection;
        //     otherwise, false.
        public bool Contains(string propertyName)
        {
            //TODO: ALACHISOFT
            throw new NotImplementedException();
        }

        public bool Contains(object key)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Copies the all objects in this collection to an array, starting at the specified
        //     index in the target array.
        //
        // Parameters:
        //   array:
        //     The array of System.DirectoryServices.PropertyValueCollection objects that receives
        //     the elements of this collection.
        //
        //   index:
        //     The zero-based index in array where this method starts copying this collection.
        //
        // Exceptions:
        //   T:System.Runtime.InteropServices.COMException:
        //     An error occurred during the call to the underlying interface.
        public void CopyTo(PropertyValueCollection[] array, int index)
        {
            //TODO: ALACHISOFT
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Returns an enumerator that you can use to iterate through this collection.
        //
        // Returns:
        //     An System.Collections.IDictionaryEnumerator that you can use to iterate through
        //     this collection.
        //
        // Exceptions:
        //   T:System.Runtime.InteropServices.COMException:
        //     An error occurred during the call to the underlying interface.
        public IDictionaryEnumerator GetEnumerator()
        {
            //TODO: ALACHISOFT
            throw new NotImplementedException();
        }

        public void Remove(object key)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
