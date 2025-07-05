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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MeshStatus : AbstractModel
    {
        
        /// <summary>
        /// 服务数量
        /// </summary>
        [JsonProperty("ServiceCount")]
        public long? ServiceCount{ get; set; }

        /// <summary>
        /// 灰度升级的版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CanaryVersion")]
        public string CanaryVersion{ get; set; }

        /// <summary>
        /// 已废弃
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Prometheus")]
        public PrometheusStatus[] Prometheus{ get; set; }

        /// <summary>
        /// 状态附带信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StateMessage")]
        public string StateMessage{ get; set; }

        /// <summary>
        /// 正在执行的异步操作
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActiveOperationList")]
        public ActiveOperation[] ActiveOperationList{ get; set; }

        /// <summary>
        /// 获取TPS信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TPS")]
        public PrometheusStatus TPS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "CanaryVersion", this.CanaryVersion);
            this.SetParamArrayObj(map, prefix + "Prometheus.", this.Prometheus);
            this.SetParamSimple(map, prefix + "StateMessage", this.StateMessage);
            this.SetParamArrayObj(map, prefix + "ActiveOperationList.", this.ActiveOperationList);
            this.SetParamObj(map, prefix + "TPS.", this.TPS);
        }
    }
}

