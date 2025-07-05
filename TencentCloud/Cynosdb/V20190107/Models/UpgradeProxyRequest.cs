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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeProxyRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// cpu核数
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 内存
        /// </summary>
        [JsonProperty("Mem")]
        public long? Mem{ get; set; }

        /// <summary>
        /// 数据库代理组节点个数
        /// </summary>
        [JsonProperty("ProxyCount")]
        public long? ProxyCount{ get; set; }

        /// <summary>
        /// 数据库代理组ID（已废弃）
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// 重新负载均衡：auto（自动），manual（手动）
        /// </summary>
        [JsonProperty("ReloadBalance")]
        public string ReloadBalance{ get; set; }

        /// <summary>
        /// 升级时间 ：no（升级完成时）yes（实例维护时间）
        /// </summary>
        [JsonProperty("IsInMaintainPeriod")]
        public string IsInMaintainPeriod{ get; set; }

        /// <summary>
        /// 数据库代理节点信息
        /// </summary>
        [JsonProperty("ProxyZones")]
        public ProxyZone[] ProxyZones{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "ProxyCount", this.ProxyCount);
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamSimple(map, prefix + "ReloadBalance", this.ReloadBalance);
            this.SetParamSimple(map, prefix + "IsInMaintainPeriod", this.IsInMaintainPeriod);
            this.SetParamArrayObj(map, prefix + "ProxyZones.", this.ProxyZones);
        }
    }
}

