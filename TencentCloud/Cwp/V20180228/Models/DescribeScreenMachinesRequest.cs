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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScreenMachinesRequest : AbstractModel
    {
        
        /// <summary>
        /// 主机区域
        /// </summary>
        [JsonProperty("MachineRegion")]
        public string MachineRegion{ get; set; }

        /// <summary>
        /// IP 支持内网IP,主机别名
        /// </summary>
        [JsonProperty("MachineIpOrAlias")]
        public string MachineIpOrAlias{ get; set; }

        /// <summary>
        /// 风险状态类型：0：全部类型，1：风险主机，2：潜在风险主机 ， 3：已关机/离线主机，4：无风险主机
        /// </summary>
        [JsonProperty("SecurityStatus")]
        public ulong? SecurityStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineRegion", this.MachineRegion);
            this.SetParamSimple(map, prefix + "MachineIpOrAlias", this.MachineIpOrAlias);
            this.SetParamSimple(map, prefix + "SecurityStatus", this.SecurityStatus);
        }
    }
}

