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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StandbyDBInstanceRelation : AbstractModel
    {
        
        /// <summary>
        /// 主实例 ID
        /// </summary>
        [JsonProperty("PrimaryInstanceId")]
        public string PrimaryInstanceId{ get; set; }

        /// <summary>
        /// 主实例名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrimaryInstanceName")]
        public string PrimaryInstanceName{ get; set; }

        /// <summary>
        /// 主实例地域
        /// </summary>
        [JsonProperty("PrimaryRegion")]
        public string PrimaryRegion{ get; set; }

        /// <summary>
        /// 主实例子网 IP
        /// </summary>
        [JsonProperty("PrimaryVip")]
        public string PrimaryVip{ get; set; }

        /// <summary>
        /// 主实例子网端口
        /// </summary>
        [JsonProperty("PrimaryVport")]
        public long? PrimaryVport{ get; set; }

        /// <summary>
        /// 主实例可用区
        /// </summary>
        [JsonProperty("PrimaryZones")]
        public string[] PrimaryZones{ get; set; }

        /// <summary>
        /// 主实例运行状态
        /// </summary>
        [JsonProperty("PrimaryStatus")]
        public string PrimaryStatus{ get; set; }

        /// <summary>
        /// 备实例 ID
        /// </summary>
        [JsonProperty("SecondaryInstanceId")]
        public string SecondaryInstanceId{ get; set; }

        /// <summary>
        /// 备实例名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecondaryInstanceName")]
        public string SecondaryInstanceName{ get; set; }

        /// <summary>
        /// 备实例地域
        /// </summary>
        [JsonProperty("SecondaryRegion")]
        public string SecondaryRegion{ get; set; }

        /// <summary>
        /// 备实例子网 IP
        /// </summary>
        [JsonProperty("SecondaryVip")]
        public string SecondaryVip{ get; set; }

        /// <summary>
        /// 备实例子网端口
        /// </summary>
        [JsonProperty("SecondaryVport")]
        public long? SecondaryVport{ get; set; }

        /// <summary>
        /// 备实例可用区
        /// </summary>
        [JsonProperty("SecondaryZones")]
        public string[] SecondaryZones{ get; set; }

        /// <summary>
        /// 备实例运行状态
        /// </summary>
        [JsonProperty("SecondaryStatus")]
        public string SecondaryStatus{ get; set; }

        /// <summary>
        /// 连接类型，log_service 或 raft
        /// </summary>
        [JsonProperty("ConnType")]
        public string ConnType{ get; set; }

        /// <summary>
        /// 同步类型，sync 或 async
        /// </summary>
        [JsonProperty("SyncMode")]
        public string SyncMode{ get; set; }

        /// <summary>
        /// 同步状态，1: 正在同步；2: 同步异常
        /// </summary>
        [JsonProperty("SyncStatus")]
        public long? SyncStatus{ get; set; }

        /// <summary>
        /// 同步状态描述，同步状态异常时的错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SyncStatusDesc")]
        public string SyncStatusDesc{ get; set; }

        /// <summary>
        /// 灾备状态描述，"creating" "running" "modifying"，无灾备关系时为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StandbyStatus")]
        public string StandbyStatus{ get; set; }

        /// <summary>
        /// 主实例版本
        /// </summary>
        [JsonProperty("PrimaryCreateVersion")]
        public string PrimaryCreateVersion{ get; set; }

        /// <summary>
        /// 备实例版本
        /// </summary>
        [JsonProperty("SecondaryCreateVersion")]
        public string SecondaryCreateVersion{ get; set; }

        /// <summary>
        /// 时延 单位为秒
        /// </summary>
        [JsonProperty("SyncDelay")]
        public long? SyncDelay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrimaryInstanceId", this.PrimaryInstanceId);
            this.SetParamSimple(map, prefix + "PrimaryInstanceName", this.PrimaryInstanceName);
            this.SetParamSimple(map, prefix + "PrimaryRegion", this.PrimaryRegion);
            this.SetParamSimple(map, prefix + "PrimaryVip", this.PrimaryVip);
            this.SetParamSimple(map, prefix + "PrimaryVport", this.PrimaryVport);
            this.SetParamArraySimple(map, prefix + "PrimaryZones.", this.PrimaryZones);
            this.SetParamSimple(map, prefix + "PrimaryStatus", this.PrimaryStatus);
            this.SetParamSimple(map, prefix + "SecondaryInstanceId", this.SecondaryInstanceId);
            this.SetParamSimple(map, prefix + "SecondaryInstanceName", this.SecondaryInstanceName);
            this.SetParamSimple(map, prefix + "SecondaryRegion", this.SecondaryRegion);
            this.SetParamSimple(map, prefix + "SecondaryVip", this.SecondaryVip);
            this.SetParamSimple(map, prefix + "SecondaryVport", this.SecondaryVport);
            this.SetParamArraySimple(map, prefix + "SecondaryZones.", this.SecondaryZones);
            this.SetParamSimple(map, prefix + "SecondaryStatus", this.SecondaryStatus);
            this.SetParamSimple(map, prefix + "ConnType", this.ConnType);
            this.SetParamSimple(map, prefix + "SyncMode", this.SyncMode);
            this.SetParamSimple(map, prefix + "SyncStatus", this.SyncStatus);
            this.SetParamSimple(map, prefix + "SyncStatusDesc", this.SyncStatusDesc);
            this.SetParamSimple(map, prefix + "StandbyStatus", this.StandbyStatus);
            this.SetParamSimple(map, prefix + "PrimaryCreateVersion", this.PrimaryCreateVersion);
            this.SetParamSimple(map, prefix + "SecondaryCreateVersion", this.SecondaryCreateVersion);
            this.SetParamSimple(map, prefix + "SyncDelay", this.SyncDelay);
        }
    }
}

