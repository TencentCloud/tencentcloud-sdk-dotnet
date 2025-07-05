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

    public class FleetAttributes : AbstractModel
    {
        
        /// <summary>
        /// 生成包 Id
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 创建服务器舰队时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 服务器舰队资源描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FleetArn")]
        public string FleetArn{ get; set; }

        /// <summary>
        /// 服务器舰队 Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FleetId")]
        public string FleetId{ get; set; }

        /// <summary>
        /// 服务器舰队类型，目前只支持ON_DEMAND
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FleetType")]
        public string FleetType{ get; set; }

        /// <summary>
        /// 服务器类型，例如S5.LARGE8
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 服务器舰队名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 游戏会话保护策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NewGameServerSessionProtectionPolicy")]
        public string NewGameServerSessionProtectionPolicy{ get; set; }

        /// <summary>
        /// 操作系统类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperatingSystem")]
        public string OperatingSystem{ get; set; }

        /// <summary>
        /// 资源创建限制策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceCreationLimitPolicy")]
        public ResourceCreationLimitPolicy ResourceCreationLimitPolicy{ get; set; }

        /// <summary>
        /// 状态：新建、下载中、验证中、生成中、激活中、活跃、异常、删除中、结束
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 服务器舰队停止状态，为空时表示自动扩缩容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StoppedActions")]
        public string[] StoppedActions{ get; set; }

        /// <summary>
        /// 服务器舰队终止时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TerminationTime")]
        public string TerminationTime{ get; set; }

        /// <summary>
        /// 时限保护超时时间，默认60分钟，最小值5，最大值1440
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GameServerSessionProtectionTimeLimit")]
        public ulong? GameServerSessionProtectionTimeLimit{ get; set; }

        /// <summary>
        /// 计费状态：未开通、已开通、异常、欠费隔离、销毁、解冻
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillingStatus")]
        public string BillingStatus{ get; set; }

        /// <summary>
        /// 标签列表，最大长度50组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 数据盘，储存类型为 SSD 云硬盘（CLOUD_SSD）时，100-32000GB；储存类型为高性能云硬盘（CLOUD_PREMIUM）时，10-32000GB；容量以10为单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataDiskInfo")]
        public DiskInfo[] DataDiskInfo{ get; set; }

        /// <summary>
        /// 系统盘，储存类型为 SSD 云硬盘（CLOUD_SSD）时，100-500GB；储存类型为高性能云硬盘（CLOUD_PREMIUM）时，50-500GB；容量以1为单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SystemDiskInfo")]
        public DiskInfo SystemDiskInfo{ get; set; }

        /// <summary>
        /// 云联网相关信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelatedCcnInfos")]
        public RelatedCcnInfo[] RelatedCcnInfos{ get; set; }

        /// <summary>
        /// fleet公网出带宽最大值，默认100Mbps，范围1-200Mbps
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "FleetArn", this.FleetArn);
            this.SetParamSimple(map, prefix + "FleetId", this.FleetId);
            this.SetParamSimple(map, prefix + "FleetType", this.FleetType);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NewGameServerSessionProtectionPolicy", this.NewGameServerSessionProtectionPolicy);
            this.SetParamSimple(map, prefix + "OperatingSystem", this.OperatingSystem);
            this.SetParamObj(map, prefix + "ResourceCreationLimitPolicy.", this.ResourceCreationLimitPolicy);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "StoppedActions.", this.StoppedActions);
            this.SetParamSimple(map, prefix + "TerminationTime", this.TerminationTime);
            this.SetParamSimple(map, prefix + "GameServerSessionProtectionTimeLimit", this.GameServerSessionProtectionTimeLimit);
            this.SetParamSimple(map, prefix + "BillingStatus", this.BillingStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "DataDiskInfo.", this.DataDiskInfo);
            this.SetParamObj(map, prefix + "SystemDiskInfo.", this.SystemDiskInfo);
            this.SetParamArrayObj(map, prefix + "RelatedCcnInfos.", this.RelatedCcnInfos);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
        }
    }
}

