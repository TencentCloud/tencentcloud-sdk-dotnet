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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SourceIpTranslationNatRule : AbstractModel
    {
        
        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 资源类型，目前包含SUBNET、NETWORKINTERFACE
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 源IP/网段
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public string PrivateIpAddress{ get; set; }

        /// <summary>
        /// 弹性IP地址池
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string[] PublicIpAddresses{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Snat规则ID
        /// </summary>
        [JsonProperty("NatGatewaySnatId")]
        public string NatGatewaySnatId{ get; set; }

        /// <summary>
        /// NAT网关的ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NatGatewayId")]
        public string NatGatewayId{ get; set; }

        /// <summary>
        /// 私有网络VPC的ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// NAT网关SNAT规则创建时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "PrivateIpAddress", this.PrivateIpAddress);
            this.SetParamArraySimple(map, prefix + "PublicIpAddresses.", this.PublicIpAddresses);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "NatGatewaySnatId", this.NatGatewaySnatId);
            this.SetParamSimple(map, prefix + "NatGatewayId", this.NatGatewayId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

