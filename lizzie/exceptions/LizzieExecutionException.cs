﻿/*
 * Copyright (c) 2018 Thomas Hansen - thomas@gaiasoul.com
 *
 * Licensed under the terms of the MIT license, see the enclosed LICENSE
 * file for details.
 */

namespace lizzie.exceptions
{
    public class LizzieExecutionException : LizzieException
    {
        public LizzieExecutionException(string message)
            : base(message)
        { }
    }
}
