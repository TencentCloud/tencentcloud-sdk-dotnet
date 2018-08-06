/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConsistencyParams : AbstractModel
    {
        
        /// <summary>
        /// 1-100的整数值，select(*)对比时每张表的抽样行数比例
        /// </summary>
        [JsonProperty("SelectRowsPerTable")]
        public long? SelectRowsPerTable{ get; set; }

        /// <summary>
        /// 1-100的整数值，select(*)对比的表的比例
        /// </summary>
        [JsonProperty("TablesSelectAll")]
        public long? TablesSelectAll{ get; set; }

        /// <summary>
        /// 1-100的整数值，select count(*)对比的表的比例
        /// </summary>
        [JsonProperty("TablesSelectCount")]
        public long? TablesSelectCount{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SelectRowsPerTable", this.SelectRowsPerTable);
            this.SetParamSimple(map, prefix + "TablesSelectAll", this.TablesSelectAll);
            this.SetParamSimple(map, prefix + "TablesSelectCount", this.TablesSelectCount);
        }
    }
}

