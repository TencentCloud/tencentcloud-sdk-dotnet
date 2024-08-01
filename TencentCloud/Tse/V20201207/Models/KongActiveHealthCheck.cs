/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KongActiveHealthCheck : AbstractModel
    {
        
        /// <summary>
        /// 主动健康检查健康探测间隔，单位：秒，0表示不开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthyInterval")]
        public ulong? HealthyInterval{ get; set; }

        /// <summary>
        /// 主动健康检查异常探测间隔，单位：秒，0表示不开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnHealthyInterval")]
        public ulong? UnHealthyInterval{ get; set; }

        /// <summary>
        /// 在 GET HTTP 请求中使用的路径，以作为主动运行状况检查的探测器运行。默认： ”/”。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpPath")]
        public string HttpPath{ get; set; }

        /// <summary>
        /// GET HTTP 请求的超时时间，单位：秒。默认 60。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timeout")]
        public float? Timeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HealthyInterval", this.HealthyInterval);
            this.SetParamSimple(map, prefix + "UnHealthyInterval", this.UnHealthyInterval);
            this.SetParamSimple(map, prefix + "HttpPath", this.HttpPath);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
        }
    }
}

