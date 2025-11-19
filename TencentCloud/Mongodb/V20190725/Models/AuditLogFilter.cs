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

    public class AuditLogFilter : AbstractModel
    {
        
        /// <summary>
        /// 客户端地址。
        /// </summary>
        [JsonProperty("Host")]
        public string[] Host{ get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("User")]
        public string[] User{ get; set; }

        /// <summary>
        /// 执行时间。单位为：ms。表示筛选执行时间大于该值的审计日志。
        /// </summary>
        [JsonProperty("ExecTime")]
        public ulong? ExecTime{ get; set; }

        /// <summary>
        /// 影响行数。表示筛选影响行数大于该值的审计日志。
        /// </summary>
        [JsonProperty("AffectRows")]
        public ulong? AffectRows{ get; set; }

        /// <summary>
        /// 操作类型。
        /// </summary>
        [JsonProperty("Atype")]
        public string[] Atype{ get; set; }

        /// <summary>
        /// 执行结果。
        /// </summary>
        [JsonProperty("Result")]
        public string[] Result{ get; set; }

        /// <summary>
        /// 根据此关键字过滤日志
        /// </summary>
        [JsonProperty("Param")]
        public string[] Param{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Host.", this.Host);
            this.SetParamArraySimple(map, prefix + "User.", this.User);
            this.SetParamSimple(map, prefix + "ExecTime", this.ExecTime);
            this.SetParamSimple(map, prefix + "AffectRows", this.AffectRows);
            this.SetParamArraySimple(map, prefix + "Atype.", this.Atype);
            this.SetParamArraySimple(map, prefix + "Result.", this.Result);
            this.SetParamArraySimple(map, prefix + "Param.", this.Param);
        }
    }
}

