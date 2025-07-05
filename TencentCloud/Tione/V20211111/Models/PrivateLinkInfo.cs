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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrivateLinkInfo : AbstractModel
    {
        
        /// <summary>
        /// 私有连接所在的VPCID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有连接所在的子网ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// HTTP内网调用地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerHttpAddr")]
        public string[] InnerHttpAddr{ get; set; }

        /// <summary>
        /// HTTPS内网调用地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerHttpsAddr")]
        public string[] InnerHttpsAddr{ get; set; }

        /// <summary>
        /// 私有连接状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// grpc内网调用地址
        /// </summary>
        [JsonProperty("InnerGrpcAddr")]
        public string[] InnerGrpcAddr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArraySimple(map, prefix + "InnerHttpAddr.", this.InnerHttpAddr);
            this.SetParamArraySimple(map, prefix + "InnerHttpsAddr.", this.InnerHttpsAddr);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamArraySimple(map, prefix + "InnerGrpcAddr.", this.InnerGrpcAddr);
        }
    }
}

