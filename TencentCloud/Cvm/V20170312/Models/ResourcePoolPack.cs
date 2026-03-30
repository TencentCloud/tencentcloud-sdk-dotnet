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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourcePoolPack : AbstractModel
    {
        
        /// <summary>
        /// 实例资源池ID。形如：rpp-rn99mzt2。
        /// </summary>
        [JsonProperty("DedicatedResourcePackId")]
        public string DedicatedResourcePackId{ get; set; }

        /// <summary>
        /// 实例资源池的名称。
        /// </summary>
        [JsonProperty("DedicatedResourcePackName")]
        public string DedicatedResourcePackName{ get; set; }

        /// <summary>
        /// 实例资源池预扣包所在可用区。形如：ap-guangzhou-6。
        /// 返回项：<a href="https://cloud.tencent.com/document/product/213/6091">可用区列表</a>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例资源池预扣包的规格，仅支持半整机/整机规格。形如：SA9.96XLARGE1152（SA9半整机）。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例资源池预扣包的实例类型。形如：SA9。
        /// </summary>
        [JsonProperty("InstanceFamily")]
        public string InstanceFamily{ get; set; }

        /// <summary>
        /// 实例资源池类型。
        /// 返回项：EXCLUSIVE (独享) | SHARED (共享)。
        /// </summary>
        [JsonProperty("ResourcePoolPackType")]
        public string ResourcePoolPackType{ get; set; }

        /// <summary>
        /// 实例资源池状态。
        /// 返回项：CREATING (创建中) | ACTIVE (运行中) | FAILED (创建失败) | RETIRED (已过期)。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 实例资源池总容量。
        /// </summary>
        [JsonProperty("TotalCapacity")]
        public ResourceCount TotalCapacity{ get; set; }

        /// <summary>
        /// 实例资源池剩余容量。
        /// </summary>
        [JsonProperty("AvailableCapacity")]
        public ResourceCount AvailableCapacity{ get; set; }

        /// <summary>
        /// 底层物理机IP（已加密）。
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// 机架ID（已加密）。
        /// </summary>
        [JsonProperty("RackId")]
        public string RackId{ get; set; }

        /// <summary>
        /// 交换机ID（已加密）。
        /// </summary>
        [JsonProperty("SwitchId")]
        public string SwitchId{ get; set; }

        /// <summary>
        /// 自动放置开关状态。开启则在不指定实例资源池创建实例时，系统会在开启了该能力的实例资源池里寻找合适的池子创建实例。关闭则在不指定实例资源池创建实例时，系统不会在该池子里创建实例，只有在指定实例资源池创建实例时，指定了该池子的ID，才允许在池子内创建实例。
        /// </summary>
        [JsonProperty("AutoPlacement")]
        public bool? AutoPlacement{ get; set; }

        /// <summary>
        /// 自动续费标识。
        /// 返回项：NOTIFY_AND_AUTO_RENEW (通知且自动续费) | NOTIFY_AND_MANUAL_RENEW (通知不自动续费) | DISABLE_NOTIFY_AND_MANUAL_RENEW (不通知不自动续费)。
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 实例资源池预扣包创建时间。按照`ISO8601`标准表示，并且使用`UTC`时间。格式为：`YYYY-MM-DDThh:mm:ssZ`。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 实例资源池到期时间。按照`ISO8601`标准表示，并且使用`UTC`时间。格式为：`YYYY-MM-DDThh:mm:ssZ`。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DedicatedResourcePackId", this.DedicatedResourcePackId);
            this.SetParamSimple(map, prefix + "DedicatedResourcePackName", this.DedicatedResourcePackName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceFamily", this.InstanceFamily);
            this.SetParamSimple(map, prefix + "ResourcePoolPackType", this.ResourcePoolPackType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "TotalCapacity.", this.TotalCapacity);
            this.SetParamObj(map, prefix + "AvailableCapacity.", this.AvailableCapacity);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "RackId", this.RackId);
            this.SetParamSimple(map, prefix + "SwitchId", this.SwitchId);
            this.SetParamSimple(map, prefix + "AutoPlacement", this.AutoPlacement);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

