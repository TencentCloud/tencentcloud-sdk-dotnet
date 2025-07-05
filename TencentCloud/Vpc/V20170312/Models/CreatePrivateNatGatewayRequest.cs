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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePrivateNatGatewayRequest : AbstractModel
    {
        
        /// <summary>
        /// 私网网关名称
        /// </summary>
        [JsonProperty("NatGatewayName")]
        public string NatGatewayName{ get; set; }

        /// <summary>
        /// 私有网络实例ID。当创建VPC类型私网NAT网关或者专线网关类型私网NAT网关时，此参数必填。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 跨域参数。仅当取值为True时，才会支持跨域绑定VPC。
        /// </summary>
        [JsonProperty("CrossDomain")]
        public bool? CrossDomain{ get; set; }

        /// <summary>
        /// 实例标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// VPC类型私网NAT网关。仅当取值为True时，才会创建VPC类型私网NAT网关。
        /// </summary>
        [JsonProperty("VpcType")]
        public bool? VpcType{ get; set; }

        /// <summary>
        /// 云联网类型私网NAT网关需要绑定的云联网实例ID。
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatGatewayName", this.NatGatewayName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "CrossDomain", this.CrossDomain);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "VpcType", this.VpcType);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
        }
    }
}

