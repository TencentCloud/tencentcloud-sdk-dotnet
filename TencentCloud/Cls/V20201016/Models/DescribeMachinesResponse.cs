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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMachinesResponse : AbstractModel
    {
        
        /// <summary>
        /// 机器状态信息组
        /// </summary>
        [JsonProperty("Machines")]
        public MachineInfo[] Machines{ get; set; }

        /// <summary>
        /// 机器组是否开启自动升级功能。 0：未开启自动升级；1：开启了自动升级。
        /// </summary>
        [JsonProperty("AutoUpdate")]
        public long? AutoUpdate{ get; set; }

        /// <summary>
        /// 机器组自动升级功能预设开始时间
        /// </summary>
        [JsonProperty("UpdateStartTime")]
        public string UpdateStartTime{ get; set; }

        /// <summary>
        /// 机器组自动升级功能预设结束时间
        /// </summary>
        [JsonProperty("UpdateEndTime")]
        public string UpdateEndTime{ get; set; }

        /// <summary>
        /// 当前用户可用最新的Loglistener版本
        /// </summary>
        [JsonProperty("LatestAgentVersion")]
        public string LatestAgentVersion{ get; set; }

        /// <summary>
        /// 是否开启服务日志
        /// </summary>
        [JsonProperty("ServiceLogging")]
        public bool? ServiceLogging{ get; set; }

        /// <summary>
        /// 总数目
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Machines.", this.Machines);
            this.SetParamSimple(map, prefix + "AutoUpdate", this.AutoUpdate);
            this.SetParamSimple(map, prefix + "UpdateStartTime", this.UpdateStartTime);
            this.SetParamSimple(map, prefix + "UpdateEndTime", this.UpdateEndTime);
            this.SetParamSimple(map, prefix + "LatestAgentVersion", this.LatestAgentVersion);
            this.SetParamSimple(map, prefix + "ServiceLogging", this.ServiceLogging);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

