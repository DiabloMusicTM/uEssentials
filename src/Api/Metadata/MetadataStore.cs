﻿/*
 *  This file is part of uEssentials project.
 *      https://uessentials.github.io/
 *
 *  Copyright (C) 2015-2016  Leonardosc
 *
 *  This program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License along
 *  with this program; if not, write to the Free Software Foundation, Inc.,
 *  51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/

using System.Collections.Generic;

namespace Essentials.Api.Metadata {

    public class MetadataStore<TValue> {

        private readonly IDictionary<string, TValue> _metadata = new Dictionary<string, TValue>();

        public TValue this[string key] {
            get { return _metadata[key]; }
            set { _metadata[key] = value; }
        }

        public bool Has(string key) {
            return _metadata.ContainsKey(key);
        }

        public void Set(string key, TValue value) {
            this[key] = value;
        }

        public TValue Get(string key) {
            return this[key];
        }

        public T Get<T>(string key) where T : TValue {
            return (T) Get(key);
        }

        public bool Remove(string key) {
            return _metadata.Remove(key);
        }

    }

}