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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccountPrivilegesResponse : AbstractModel
    {
        
        /// <summary>
        /// 全局权限数组。
        /// </summary>
        [JsonProperty("GlobalPrivileges")]
        public string[] GlobalPrivileges{ get; set; }

        /// <summary>
        /// 数据库权限数组。
        /// </summary>
        [JsonProperty("DatabasePrivileges")]
        public DatabasePrivilege[] DatabasePrivileges{ get; set; }

        /// <summary>
        /// 数据库中的表权限数组。
        /// </summary>
        [JsonProperty("TablePrivileges")]
        public TablePrivilege[] TablePrivileges{ get; set; }

        /// <summary>
        /// 数据库表中的列权限数组。
        /// </summary>
        [JsonProperty("ColumnPrivileges")]
        public ColumnPrivilege[] ColumnPrivileges{ get; set; }

        /// <summary>
        /// 唯一请求ID，每次请求都会返回。定位问题时需要提供该次请求的RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "GlobalPrivileges.", this.GlobalPrivileges);
            this.SetParamArrayObj(map, prefix + "DatabasePrivileges.", this.DatabasePrivileges);
            this.SetParamArrayObj(map, prefix + "TablePrivileges.", this.TablePrivileges);
            this.SetParamArrayObj(map, prefix + "ColumnPrivileges.", this.ColumnPrivileges);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

