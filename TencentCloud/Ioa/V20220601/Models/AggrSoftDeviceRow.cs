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
        /// 终端名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 最近登录账号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastLoginAccount")]
        public string LastLoginAccount{ get; set; }

        /// <summary>
        /// 终端用户名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeviceUserName")]
        public string DeviceUserName{ get; set; }

        /// <summary>
        /// 软件版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 是否盗版
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PiracyRisk")]
        public long? PiracyRisk{ get; set; }

        /// <summary>
        /// 盗版原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PiracyReason")]
        public string PiracyReason{ get; set; }

        /// <summary>
        /// 安装时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstallTime")]
        public string InstallTime{ get; set; }

        /// <summary>
        /// 用户目录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserPath")]
        public string UserPath{ get; set; }

        /// <summary>
        /// 所在分组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserGroup")]
        public string UserGroup{ get; set; }

        /// <summary>
        /// IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// MAC
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MAC")]
        public string MAC{ get; set; }

        /// <summary>
        /// 使用时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UseTime")]
        public long? UseTime{ get; set; }

        /// <summary>
        /// 设备ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeviceId")]
        public long? DeviceId{ get; set; }

        /// <summary>
        /// 软件全名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FullSoftName")]
        public string FullSoftName{ get; set; }

        /// <summary>
        /// 数据ID（唯一）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 该终端此款软件可升级到的目标版本号
        /// </summary>
        [JsonProperty("NewVersion")]
        public string NewVersion{ get; set; }

        /// <summary>
        /// 该软件对应运营配置的可升级id
        /// </summary>
        [JsonProperty("UpgradeSoftId")]
        public long? UpgradeSoftId{ get; set; }

        /// <summary>
        /// 终端备注名
        /// </summary>
        [JsonProperty("RemarkName")]
        public string RemarkName{ get; set; }


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
        }
    }
}

