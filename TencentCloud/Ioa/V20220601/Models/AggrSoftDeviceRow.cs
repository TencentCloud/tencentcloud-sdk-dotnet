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

    public class AggrSoftDeviceRow : AbstractModel
    {
        
        /// <summary>
        /// <p>终端名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>最近登录账号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastLoginAccount")]
        public string LastLoginAccount{ get; set; }

        /// <summary>
        /// <p>终端用户名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeviceUserName")]
        public string DeviceUserName{ get; set; }

        /// <summary>
        /// <p>软件版本</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>是否盗版</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PiracyRisk")]
        public long? PiracyRisk{ get; set; }

        /// <summary>
        /// <p>盗版原因</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PiracyReason")]
        public string PiracyReason{ get; set; }

        /// <summary>
        /// <p>安装时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstallTime")]
        public string InstallTime{ get; set; }

        /// <summary>
        /// <p>用户目录</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserPath")]
        public string UserPath{ get; set; }

        /// <summary>
        /// <p>所在分组</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserGroup")]
        public string UserGroup{ get; set; }

        /// <summary>
        /// <p>IP</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// <p>MAC</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MAC")]
        public string MAC{ get; set; }

        /// <summary>
        /// <p>使用时长</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UseTime")]
        public long? UseTime{ get; set; }

        /// <summary>
        /// <p>设备ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeviceId")]
        public long? DeviceId{ get; set; }

        /// <summary>
        /// <p>软件全名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FullSoftName")]
        public string FullSoftName{ get; set; }

        /// <summary>
        /// <p>数据ID（唯一）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>该终端此款软件可升级到的目标版本号</p>
        /// </summary>
        [JsonProperty("NewVersion")]
        public string NewVersion{ get; set; }

        /// <summary>
        /// <p>该软件对应运营配置的可升级id</p>
        /// </summary>
        [JsonProperty("UpgradeSoftId")]
        public long? UpgradeSoftId{ get; set; }

        /// <summary>
        /// <p>终端备注名</p>
        /// </summary>
        [JsonProperty("RemarkName")]
        public string RemarkName{ get; set; }

        /// <summary>
        /// <p>软件id</p>
        /// </summary>
        [JsonProperty("SoftwareId")]
        public long? SoftwareId{ get; set; }

        /// <summary>
        /// <p>0:win 2:mac</p>
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }

        /// <summary>
        /// <p>所有权</p>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "LastLoginAccount", this.LastLoginAccount);
            this.SetParamSimple(map, prefix + "DeviceUserName", this.DeviceUserName);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "PiracyRisk", this.PiracyRisk);
            this.SetParamSimple(map, prefix + "PiracyReason", this.PiracyReason);
            this.SetParamSimple(map, prefix + "InstallTime", this.InstallTime);
            this.SetParamSimple(map, prefix + "UserPath", this.UserPath);
            this.SetParamSimple(map, prefix + "UserGroup", this.UserGroup);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "MAC", this.MAC);
            this.SetParamSimple(map, prefix + "UseTime", this.UseTime);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "FullSoftName", this.FullSoftName);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "NewVersion", this.NewVersion);
            this.SetParamSimple(map, prefix + "UpgradeSoftId", this.UpgradeSoftId);
            this.SetParamSimple(map, prefix + "RemarkName", this.RemarkName);
            this.SetParamSimple(map, prefix + "SoftwareId", this.SoftwareId);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
        }
    }
}

