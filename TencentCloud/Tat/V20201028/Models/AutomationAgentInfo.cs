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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutomationAgentInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Agent 版本号。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 上次心跳时间
        /// </summary>
        [JsonProperty("LastHeartbeatTime")]
        public string LastHeartbeatTime{ get; set; }

        /// <summary>
        /// Agent状态，取值范围：
        /// Online：在线，Offline：离线
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// Agent运行环境，取值范围：Linux：Linux实例Windows：Windows实例
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }

        /// <summary>
        /// Agent 支持的功能列表。
        /// </summary>
        [JsonProperty("SupportFeatures")]
        public string[] SupportFeatures{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "LastHeartbeatTime", this.LastHeartbeatTime);
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
            this.SetParamArraySimple(map, prefix + "SupportFeatures.", this.SupportFeatures);
        }
    }
}

