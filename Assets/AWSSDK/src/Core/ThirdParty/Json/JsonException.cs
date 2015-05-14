//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//
#pragma warning disable 1587
#region Header
///
/// JsonException.cs
///   Base class throwed by LitJSON when a parsing error occurs.
///
/// The authors disclaim copyright to this source code. For more details, see
/// the COPYING file included with this distribution.
///
#endregion


using System;


namespace ThirdParty.Json.LitJson
{
    public class JsonException : Exception
    {
        public JsonException () : base ()
        {
        }

        internal JsonException (ParserToken token) :
            base (String.Format (
                    "Invalid token '{0}' in input string", token))
        {
        }

        internal JsonException (ParserToken token,
                                Exception inner_exception) :
            base (String.Format (
                    "Invalid token '{0}' in input string", token),
                inner_exception)
        {
        }

        internal JsonException (int c) :
            base (String.Format (
                    "Invalid character '{0}' in input string", (char) c))
        {
        }

        internal JsonException (int c, Exception inner_exception) :
            base (String.Format (
                    "Invalid character '{0}' in input string", (char) c),
                inner_exception)
        {
        }


        public JsonException (string message) : base (message)
        {
        }

        public JsonException (string message, Exception inner_exception) :
            base (message, inner_exception)
        {
        }
    }
}