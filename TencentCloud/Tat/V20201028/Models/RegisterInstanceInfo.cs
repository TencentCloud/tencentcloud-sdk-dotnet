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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegisterInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// 注册码ID。
        /// </summary>
        [JsonProperty("RegisterCodeId")]
        public string RegisterCodeId{ get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 机器ID。
        /// </summary>
        [JsonProperty("MachineId")]
        public string MachineId{ get; set; }

        /// <summary>
        /// 系统名。
        /// </summary>
        [JsonProperty("SystemName")]
        public string SystemName{ get; set; }

        /// <summary>
        /// 主机名。
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 内网IP。
        /// </summary>
        [JsonProperty("LocalIp")]
        public string LocalIp{ get; set; }

        /// <summary>
        /// 公钥。
        /// </summary>
        [JsonProperty("PublicKey")]
        public string PublicKey{ get; set; }

        /// <summary>
        /// 托管状态。
        /// 返回Online表示实例正在托管，返回Offline表示实例未托管。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 上次更新时间。
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegisterCodeId", this.RegisterCodeId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "MachineId", this.MachineId);
            this.SetParamSimple(map, prefix + "SystemName", this.SystemName);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "LocalIp", this.LocalIp);
            this.SetParamSimple(map, prefix + "PublicKey", this.PublicKey);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
        }
    }
}

