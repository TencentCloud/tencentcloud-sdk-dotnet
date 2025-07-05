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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CopyFleetRequest : AbstractModel
    {
        
        /// <summary>
        /// 服务器舰队 Id
        /// </summary>
        [JsonProperty("FleetId")]
        public string FleetId{ get; set; }

        /// <summary>
        /// 复制数量，最小值1，最大值为剩余配额，可以根据[获取用户配额](https://cloud.tencent.com/document/product/1165/48732)接口获取。
        /// </summary>
        [JsonProperty("CopyNumber")]
        public long? CopyNumber{ get; set; }

        /// <summary>
        /// 生成包 Id
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 描述，最小长度0，最大长度100
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 网络配置
        /// </summary>
        [JsonProperty("InboundPermissions")]
        public InboundPermission[] InboundPermissions{ get; set; }

        /// <summary>
        /// 服务器类型，参数根据[获取服务器实例类型列表](https://cloud.tencent.com/document/product/1165/48732)接口获取。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 服务器舰队类型，目前只支持ON_DEMAND类型
        /// </summary>
        [JsonProperty("FleetType")]
        public string FleetType{ get; set; }

        /// <summary>
        /// 服务器舰队名称，最小长度1，最大长度50
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 保护策略：不保护NoProtection、完全保护FullProtection、时限保护TimeLimitProtection
        /// </summary>
        [JsonProperty("NewGameServerSessionProtectionPolicy")]
        public string NewGameServerSessionProtectionPolicy{ get; set; }

        /// <summary>
        /// 资源创建限制策略
        /// </summary>
        [JsonProperty("ResourceCreationLimitPolicy")]
        public ResourceCreationLimitPolicy ResourceCreationLimitPolicy{ get; set; }

        /// <summary>
        /// 进程配置
        /// </summary>
        [JsonProperty("RuntimeConfiguration")]
        public RuntimeConfiguration RuntimeConfiguration{ get; set; }

        /// <summary>
        /// 时限保护超时时间，默认60分钟，最小值5，最大值1440；当NewGameSessionProtectionPolicy为TimeLimitProtection时参数有效
        /// </summary>
        [JsonProperty("GameServerSessionProtectionTimeLimit")]
        public long? GameServerSessionProtectionTimeLimit{ get; set; }

        /// <summary>
        /// 是否选择扩缩容：SCALING_SELECTED 或者 SCALING_UNSELECTED；默认是 SCALING_UNSELECTED
        /// </summary>
        [JsonProperty("SelectedScalingType")]
        public string SelectedScalingType{ get; set; }

        /// <summary>
        /// 是否选择云联网：CCN_SELECTED_BEFORE_CREATE（创建前关联）， CCN_SELECTED_AFTER_CREATE（创建后关联）或者 CCN_UNSELECTED（不关联）；默认是 CCN_UNSELECTED
        /// </summary>
        [JsonProperty("SelectedCcnType")]
        public string SelectedCcnType{ get; set; }

        /// <summary>
        /// 标签列表，最大长度50组
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 系统盘，储存类型为 SSD 云硬盘（CLOUD_SSD）时，100-500GB；储存类型为高性能云硬盘（CLOUD_PREMIUM）时，50-500GB；容量以1为单位
        /// </summary>
        [JsonProperty("SystemDiskInfo")]
        public DiskInfo SystemDiskInfo{ get; set; }

        /// <summary>
        /// 数据盘，储存类型为 SSD 云硬盘（CLOUD_SSD）时，100-32000GB；储存类型为高性能云硬盘（CLOUD_PREMIUM）时，10-32000GB；容量以10为单位
        /// </summary>
        [JsonProperty("DataDiskInfo")]
        public DiskInfo[] DataDiskInfo{ get; set; }

        /// <summary>
        /// 是否选择复制定时器策略：TIMER_SELECTED 或者 TIMER_UNSELECTED；默认是 TIMER_UNSELECTED
        /// </summary>
        [JsonProperty("SelectedTimerType")]
        public string SelectedTimerType{ get; set; }

        /// <summary>
        /// 云联网信息，包含对应的账号信息及所属id
        /// </summary>
        [JsonProperty("CcnInfos")]
        public CcnInfo[] CcnInfos{ get; set; }

        /// <summary>
        /// fleet公网出带宽最大值，默认100Mbps，范围1-200Mbps
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FleetId", this.FleetId);
            this.SetParamSimple(map, prefix + "CopyNumber", this.CopyNumber);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "InboundPermissions.", this.InboundPermissions);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "FleetType", this.FleetType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NewGameServerSessionProtectionPolicy", this.NewGameServerSessionProtectionPolicy);
            this.SetParamObj(map, prefix + "ResourceCreationLimitPolicy.", this.ResourceCreationLimitPolicy);
            this.SetParamObj(map, prefix + "RuntimeConfiguration.", this.RuntimeConfiguration);
            this.SetParamSimple(map, prefix + "GameServerSessionProtectionTimeLimit", this.GameServerSessionProtectionTimeLimit);
            this.SetParamSimple(map, prefix + "SelectedScalingType", this.SelectedScalingType);
            this.SetParamSimple(map, prefix + "SelectedCcnType", this.SelectedCcnType);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "SystemDiskInfo.", this.SystemDiskInfo);
            this.SetParamArrayObj(map, prefix + "DataDiskInfo.", this.DataDiskInfo);
            this.SetParamSimple(map, prefix + "SelectedTimerType", this.SelectedTimerType);
            this.SetParamArrayObj(map, prefix + "CcnInfos.", this.CcnInfos);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
        }
    }
}

