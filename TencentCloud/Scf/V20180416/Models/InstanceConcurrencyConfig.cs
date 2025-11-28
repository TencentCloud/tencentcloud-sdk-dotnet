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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceConcurrencyConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否开启智能动态并发。'FALSE'时是静态并发。''时取消多并发配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DynamicEnabled")]
        public string DynamicEnabled{ get; set; }

        /// <summary>
        /// 单实例并发数最大值。取值范围 [1,100]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxConcurrency")]
        public ulong? MaxConcurrency{ get; set; }

        /// <summary>
        /// 安全隔离开关
        /// </summary>
        [JsonProperty("InstanceIsolationEnabled")]
        public string InstanceIsolationEnabled{ get; set; }

        /// <summary>
        /// 基于会话：Session-Based ， 或者基于请求：Request-Based，二选一
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 动态并发参数
        /// </summary>
        [JsonProperty("MixNodeConfig")]
        public MixNodeConfig[] MixNodeConfig{ get; set; }

        /// <summary>
        /// 会话配置参数
        /// </summary>
        [JsonProperty("SessionConfig")]
        public SessionConfig SessionConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DynamicEnabled", this.DynamicEnabled);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
            this.SetParamSimple(map, prefix + "InstanceIsolationEnabled", this.InstanceIsolationEnabled);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "MixNodeConfig.", this.MixNodeConfig);
            this.SetParamObj(map, prefix + "SessionConfig.", this.SessionConfig);
        }
    }
}

