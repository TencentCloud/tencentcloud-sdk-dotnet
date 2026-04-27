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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditLogFilter : AbstractModel
    {
        
        /// <summary>
        /// <p>影响函数</p>
        /// </summary>
        [JsonProperty("AffectRows")]
        public ulong? AffectRows{ get; set; }

        /// <summary>
        /// <p>数据库名字</p>
        /// </summary>
        [JsonProperty("DBName")]
        public string[] DBName{ get; set; }

        /// <summary>
        /// <p>执行时间</p>
        /// </summary>
        [JsonProperty("ExecTime")]
        public ulong? ExecTime{ get; set; }

        /// <summary>
        /// <p>主机Host</p>
        /// </summary>
        [JsonProperty("Host")]
        public string[] Host{ get; set; }

        /// <summary>
        /// <p>sql语句</p>
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// <p>登录名</p>
        /// </summary>
        [JsonProperty("User")]
        public string[] User{ get; set; }

        /// <summary>
        /// <p>审计类型</p>
        /// </summary>
        [JsonProperty("SqlType")]
        public string[] SqlType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AffectRows", this.AffectRows);
            this.SetParamArraySimple(map, prefix + "DBName.", this.DBName);
            this.SetParamSimple(map, prefix + "ExecTime", this.ExecTime);
            this.SetParamArraySimple(map, prefix + "Host.", this.Host);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamArraySimple(map, prefix + "User.", this.User);
            this.SetParamArraySimple(map, prefix + "SqlType.", this.SqlType);
        }
    }
}

