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

    public class DescribeMachineInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 机器ip。
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// 受主机安全保护天数。
        /// </summary>
        [JsonProperty("ProtectDays")]
        public ulong? ProtectDays{ get; set; }

        /// <summary>
        /// 操作系统。
        /// </summary>
        [JsonProperty("MachineOs")]
        public string MachineOs{ get; set; }

        /// <summary>
        /// 主机名称。
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// 在线状态。
        /// <li>ONLINE： 在线</li>
        /// <li>OFFLINE：离线</li>
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// CVM或BM主机唯一标识。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 主机外网IP。
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// CVM或BM主机唯一Uuid。
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 主机安全客户端唯一Uuid。
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 是否开通专业版。
        /// <li>true：是</li>
        /// <li>false：否</li>
        /// </summary>
        [JsonProperty("IsProVersion")]
        public bool? IsProVersion{ get; set; }

        /// <summary>
        /// 专业版开通时间。
        /// </summary>
        [JsonProperty("ProVersionOpenDate")]
        public string ProVersionOpenDate{ get; set; }

        /// <summary>
        /// 云服务器类型。
        /// <li>CVM: 腾讯云服务器</li>
        /// <li>BM: 黑石物理机</li>
        /// <li>ECM: 边缘计算服务器</li>
        /// <li>LH: 轻量应用服务器</li>
        /// <li>Other: 混合云机器</li>
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// 机器所属地域。如：ap-guangzhou，ap-shanghai
        /// </summary>
        [JsonProperty("MachineRegion")]
        public string MachineRegion{ get; set; }

        /// <summary>
        /// 主机状态。
        /// <li>POSTPAY: 表示后付费，即按量计费  </li>
        /// <li>PREPAY: 表示预付费，即包年包月</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 免费木马剩余检测数量。
        /// </summary>
        [JsonProperty("FreeMalwaresLeft")]
        public ulong? FreeMalwaresLeft{ get; set; }

        /// <summary>
        /// 免费漏洞剩余检测数量。
        /// </summary>
        [JsonProperty("FreeVulsLeft")]
        public ulong? FreeVulsLeft{ get; set; }

        /// <summary>
        /// agent版本号
        /// </summary>
        [JsonProperty("AgentVersion")]
        public string AgentVersion{ get; set; }

        /// <summary>
        /// 专业版到期时间(仅预付费)
        /// </summary>
        [JsonProperty("ProVersionDeadline")]
        public string ProVersionDeadline{ get; set; }

        /// <summary>
        /// 是否有资产扫描记录，0无，1有
        /// </summary>
        [JsonProperty("HasAssetScan")]
        public ulong? HasAssetScan{ get; set; }

        /// <summary>
        /// 防护版本：BASIC_VERSION 基础版，PRO_VERSION 专业版，Flagship 旗舰版，GENERAL_DISCOUNT 轻量版
        /// </summary>
        [JsonProperty("ProtectType")]
        public string ProtectType{ get; set; }

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
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "ProtectDays", this.ProtectDays);
            this.SetParamSimple(map, prefix + "MachineOs", this.MachineOs);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "IsProVersion", this.IsProVersion);
            this.SetParamSimple(map, prefix + "ProVersionOpenDate", this.ProVersionOpenDate);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "MachineRegion", this.MachineRegion);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "FreeMalwaresLeft", this.FreeMalwaresLeft);
            this.SetParamSimple(map, prefix + "FreeVulsLeft", this.FreeVulsLeft);
            this.SetParamSimple(map, prefix + "AgentVersion", this.AgentVersion);
            this.SetParamSimple(map, prefix + "ProVersionDeadline", this.ProVersionDeadline);
            this.SetParamSimple(map, prefix + "HasAssetScan", this.HasAssetScan);
            this.SetParamSimple(map, prefix + "ProtectType", this.ProtectType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

