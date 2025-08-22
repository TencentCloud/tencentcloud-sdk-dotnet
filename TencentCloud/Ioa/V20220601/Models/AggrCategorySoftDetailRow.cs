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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AggrCategorySoftDetailRow : AbstractModel
    {
        
        /// <summary>
        /// ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 软件名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 盗版风险
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PiracyRisk")]
        public long? PiracyRisk{ get; set; }

        /// <summary>
        /// 系统平台
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }

        /// <summary>
        /// 企业名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CorpName")]
        public string CorpName{ get; set; }

        /// <summary>
        /// 安装设备数量(只支持32位)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstalledDeviceNum")]
        public long? InstalledDeviceNum{ get; set; }

        /// <summary>
        /// 盗版安装设备数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PiracyInstalledDeviceNum")]
        public long? PiracyInstalledDeviceNum{ get; set; }

        /// <summary>
        /// 已安装用户数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstalledUserNum")]
        public long? InstalledUserNum{ get; set; }

        /// <summary>
        /// 盗版软件用户数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PiracyInstalledUserNum")]
        public long? PiracyInstalledUserNum{ get; set; }

        /// <summary>
        /// 授权总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthNum")]
        public long? AuthNum{ get; set; }

        /// <summary>
        /// 正版率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GenuineRate")]
        public float? GenuineRate{ get; set; }

        /// <summary>
        /// 有新版本可升级的设备数量
        /// </summary>
        [JsonProperty("UpgradableDeviceNum")]
        public long? UpgradableDeviceNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PiracyRisk", this.PiracyRisk);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "CorpName", this.CorpName);
            this.SetParamSimple(map, prefix + "InstalledDeviceNum", this.InstalledDeviceNum);
            this.SetParamSimple(map, prefix + "PiracyInstalledDeviceNum", this.PiracyInstalledDeviceNum);
            this.SetParamSimple(map, prefix + "InstalledUserNum", this.InstalledUserNum);
            this.SetParamSimple(map, prefix + "PiracyInstalledUserNum", this.PiracyInstalledUserNum);
            this.SetParamSimple(map, prefix + "AuthNum", this.AuthNum);
            this.SetParamSimple(map, prefix + "GenuineRate", this.GenuineRate);
            this.SetParamSimple(map, prefix + "UpgradableDeviceNum", this.UpgradableDeviceNum);
        }
    }
}

