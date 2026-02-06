/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunSqlRequest : AbstractModel
    {
        
        /// <summary>
        /// 要执行的SQL语句
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// 云开发环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 数据库连接器实例信息
        /// </summary>
        [JsonProperty("DbInstance")]
        public DbInstance DbInstance{ get; set; }

        /// <summary>
        /// 是否只读；当 `true` 时仅允许以 `SELECT/WITH/SHOW/DESCRIBE/DESC/EXPLAIN` 开头的 SQL
        /// </summary>
        [JsonProperty("ReadOnly")]
        public bool? ReadOnly{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamObj(map, prefix + "DbInstance.", this.DbInstance);
            this.SetParamSimple(map, prefix + "ReadOnly", this.ReadOnly);
        }
    }
}

