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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EngineNetworkInfo : AbstractModel
    {
        
        /// <summary>
        /// 引擎网络名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineNetworkName")]
        public string EngineNetworkName{ get; set; }

        /// <summary>
        /// 引擎网络状态，0--初始化，2--可用，-1--已删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineNetworkState")]
        public long? EngineNetworkState{ get; set; }

        /// <summary>
        /// 引擎网络cidr
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineNetworkCidr")]
        public string EngineNetworkCidr{ get; set; }

        /// <summary>
        /// 引擎网络ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineNetworkId")]
        public string EngineNetworkId{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// 私有连接个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrivateLinkNumber")]
        public long? PrivateLinkNumber{ get; set; }

        /// <summary>
        /// 计算引擎个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineNumber")]
        public long? EngineNumber{ get; set; }

        /// <summary>
        /// 网关信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GateWayInfo")]
        public GatewayInfo[] GateWayInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineNetworkName", this.EngineNetworkName);
            this.SetParamSimple(map, prefix + "EngineNetworkState", this.EngineNetworkState);
            this.SetParamSimple(map, prefix + "EngineNetworkCidr", this.EngineNetworkCidr);
            this.SetParamSimple(map, prefix + "EngineNetworkId", this.EngineNetworkId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "PrivateLinkNumber", this.PrivateLinkNumber);
            this.SetParamSimple(map, prefix + "EngineNumber", this.EngineNumber);
            this.SetParamArrayObj(map, prefix + "GateWayInfo.", this.GateWayInfo);
        }
    }
}

