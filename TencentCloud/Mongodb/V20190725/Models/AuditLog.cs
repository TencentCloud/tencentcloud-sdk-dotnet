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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditLog : AbstractModel
    {
        
        /// <summary>
        /// 影响行数
        /// </summary>
        [JsonProperty("AffectRows")]
        public ulong? AffectRows{ get; set; }

        /// <summary>
        /// 操作类型。如：grantRolesToRole、dropRole等。
        /// </summary>
        [JsonProperty("Atype")]
        public string Atype{ get; set; }

        /// <summary>
        /// 执行时间。单位为：ms。
        /// </summary>
        [JsonProperty("ExecTime")]
        public ulong? ExecTime{ get; set; }

        /// <summary>
        /// 客户端地址。
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 操作参数。包含操作的详细参数信息。
        /// </summary>
        [JsonProperty("Param")]
        public string Param{ get; set; }

        /// <summary>
        /// 执行结果。0表示成功，非0表示失败。
        /// </summary>
        [JsonProperty("Result")]
        public long? Result{ get; set; }

        /// <summary>
        /// 用户角色列表。格式为：role@db,role@db。
        /// </summary>
        [JsonProperty("Roles")]
        public string Roles{ get; set; }

        /// <summary>
        /// 操作时间戳。格式为：YYYY-MM-DD HH:mm:ss。
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// 用户名。格式为：user@db。
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AffectRows", this.AffectRows);
            this.SetParamSimple(map, prefix + "Atype", this.Atype);
            this.SetParamSimple(map, prefix + "ExecTime", this.ExecTime);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Param", this.Param);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Roles", this.Roles);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "User", this.User);
        }
    }
}

