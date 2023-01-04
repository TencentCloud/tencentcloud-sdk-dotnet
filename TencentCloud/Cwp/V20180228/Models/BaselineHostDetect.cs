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

    public class BaselineHostDetect : AbstractModel
    {
        
        /// <summary>
        /// 主机Id
        /// </summary>
        [JsonProperty("HostId")]
        public string HostId{ get; set; }

        /// <summary>
        /// 内网Ip
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 外网Ip
        /// </summary>
        [JsonProperty("WanIp")]
        public string WanIp{ get; set; }

        /// <summary>
        /// 0:未通过 1:忽略 3:通过 5:检测中
        /// </summary>
        [JsonProperty("DetectStatus")]
        public long? DetectStatus{ get; set; }

        /// <summary>
        /// 检测通过数
        /// </summary>
        [JsonProperty("PassedItemCount")]
        public long? PassedItemCount{ get; set; }

        /// <summary>
        /// 关联检测项数
        /// </summary>
        [JsonProperty("ItemCount")]
        public long? ItemCount{ get; set; }

        /// <summary>
        /// 检测未通过数
        /// </summary>
        [JsonProperty("NotPassedItemCount")]
        public long? NotPassedItemCount{ get; set; }

        /// <summary>
        /// 首次检测时间
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// 最后检测时间
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// 主机安全UUID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 主机额外信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "WanIp", this.WanIp);
            this.SetParamSimple(map, prefix + "DetectStatus", this.DetectStatus);
            this.SetParamSimple(map, prefix + "PassedItemCount", this.PassedItemCount);
            this.SetParamSimple(map, prefix + "ItemCount", this.ItemCount);
            this.SetParamSimple(map, prefix + "NotPassedItemCount", this.NotPassedItemCount);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
        }
    }
}

