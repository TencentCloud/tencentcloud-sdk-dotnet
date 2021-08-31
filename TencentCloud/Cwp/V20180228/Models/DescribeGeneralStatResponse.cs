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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeGeneralStatResponse : AbstractModel
    {
        
        /// <summary>
        /// 云主机总数
        /// </summary>
        [JsonProperty("MachinesAll")]
        public ulong? MachinesAll{ get; set; }

        /// <summary>
        /// 云主机没有安装主机安全客户端的总数
        /// </summary>
        [JsonProperty("MachinesUninstalled")]
        public ulong? MachinesUninstalled{ get; set; }

        /// <summary>
        /// 主机安全客户端总数的总数
        /// </summary>
        [JsonProperty("AgentsAll")]
        public ulong? AgentsAll{ get; set; }

        /// <summary>
        /// 主机安全客户端在线的总数
        /// </summary>
        [JsonProperty("AgentsOnline")]
        public ulong? AgentsOnline{ get; set; }

        /// <summary>
        /// 主机安全客户端 离线+关机 的总数
        /// </summary>
        [JsonProperty("AgentsOffline")]
        public ulong? AgentsOffline{ get; set; }

        /// <summary>
        /// 主机安全客户端专业版的总数
        /// </summary>
        [JsonProperty("AgentsPro")]
        public ulong? AgentsPro{ get; set; }

        /// <summary>
        /// 主机安全客户端基础版的总数
        /// </summary>
        [JsonProperty("AgentsBasic")]
        public ulong? AgentsBasic{ get; set; }

        /// <summary>
        /// 7天内到期的预付费专业版总数
        /// </summary>
        [JsonProperty("AgentsProExpireWithInSevenDays")]
        public ulong? AgentsProExpireWithInSevenDays{ get; set; }

        /// <summary>
        /// 风险主机总数
        /// </summary>
        [JsonProperty("RiskMachine")]
        public ulong? RiskMachine{ get; set; }

        /// <summary>
        /// 已关机总数
        /// </summary>
        [JsonProperty("Shutdown")]
        public ulong? Shutdown{ get; set; }

        /// <summary>
        /// 已离线总数
        /// </summary>
        [JsonProperty("Offline")]
        public ulong? Offline{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachinesAll", this.MachinesAll);
            this.SetParamSimple(map, prefix + "MachinesUninstalled", this.MachinesUninstalled);
            this.SetParamSimple(map, prefix + "AgentsAll", this.AgentsAll);
            this.SetParamSimple(map, prefix + "AgentsOnline", this.AgentsOnline);
            this.SetParamSimple(map, prefix + "AgentsOffline", this.AgentsOffline);
            this.SetParamSimple(map, prefix + "AgentsPro", this.AgentsPro);
            this.SetParamSimple(map, prefix + "AgentsBasic", this.AgentsBasic);
            this.SetParamSimple(map, prefix + "AgentsProExpireWithInSevenDays", this.AgentsProExpireWithInSevenDays);
            this.SetParamSimple(map, prefix + "RiskMachine", this.RiskMachine);
            this.SetParamSimple(map, prefix + "Shutdown", this.Shutdown);
            this.SetParamSimple(map, prefix + "Offline", this.Offline);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

