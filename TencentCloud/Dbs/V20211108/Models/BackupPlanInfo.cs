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

namespace TencentCloud.Dbs.V20211108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupPlanInfo : AbstractModel
    {
        
        /// <summary>
        /// 地域信息。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 备份计划 ID。
        /// </summary>
        [JsonProperty("BackupPlanId")]
        public string BackupPlanId{ get; set; }

        /// <summary>
        /// 备份计划名称。
        /// </summary>
        [JsonProperty("BackupPlanName")]
        public string BackupPlanName{ get; set; }

        /// <summary>
        /// 备份计划状态。可能的取值为：
        /// "notStarted" - 未启动;
        /// "checking" - 校验中;
        /// "checkPass" - 校验通过;
        /// "checkNotPass" - 校验未通过;
        /// "running" - 运行中;
        /// "fullBacking" - 全量备份中;
        /// "isolating" - 隔离中;
        /// "isolated" - 已隔离;
        /// "offlining" - 下线中;
        /// "offlined" - 已下线;
        /// "paused" - 已暂停。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 数据库类型。
        /// </summary>
        [JsonProperty("DatabaseType")]
        public string DatabaseType{ get; set; }

        /// <summary>
        /// 访问类型。可能的取值为：
        /// "extranet" - 外网;
        /// "cvm" - cvm 自建实例;
        /// "dcg" - 专线接入;
        /// "vpncloud" - 云vpn接入;
        /// "cdb" - 腾讯云数据库实例;
        /// "ccn" - 云联网。
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// 源实例信息。
        /// </summary>
        [JsonProperty("SourceInfo")]
        public string[] SourceInfo{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 到期时间。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 下线时间。
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }

        /// <summary>
        /// 实例规格类型。可能的取值为：["micro", "small", "medium", "large", "xlarge"]。
        /// </summary>
        [JsonProperty("InstanceClass")]
        public string InstanceClass{ get; set; }

        /// <summary>
        /// 备份方式。可能的取值为：
        /// "logical" - 逻辑备份;
        /// "physical" - 物理备份。
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// 标签信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 自动续费标记。可能的取值为：
        /// 0 - 未开启自动续费;
        /// 1 - 已开启自动续费;
        /// 2 - 已关闭自动续费。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 是否开启增量备份标记。
        /// </summary>
        [JsonProperty("EnableIncrement")]
        public bool? EnableIncrement{ get; set; }

        /// <summary>
        /// 付费类型。可能的取值为：
        /// "prePay" - 预付费类型;
        /// "postPay" - 后付费类型。
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// 源端信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SetSourceInfo")]
        public string[] SetSourceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "BackupPlanId", this.BackupPlanId);
            this.SetParamSimple(map, prefix + "BackupPlanName", this.BackupPlanName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DatabaseType", this.DatabaseType);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamArraySimple(map, prefix + "SourceInfo.", this.SourceInfo);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
            this.SetParamSimple(map, prefix + "InstanceClass", this.InstanceClass);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "EnableIncrement", this.EnableIncrement);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamArraySimple(map, prefix + "SetSourceInfo.", this.SetSourceInfo);
        }
    }
}

