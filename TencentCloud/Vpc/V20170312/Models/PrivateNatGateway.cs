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

    public class PrivateNatGateway : AbstractModel
    {
        
        /// <summary>
        /// 私网网关`ID`。
        /// </summary>
        [JsonProperty("NatGatewayId")]
        public string NatGatewayId{ get; set; }

        /// <summary>
        /// 私网网关名称。
        /// </summary>
        [JsonProperty("NatGatewayName")]
        public string NatGatewayName{ get; set; }

        /// <summary>
        /// 私网网关关联`VPC`实例`ID`。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私网网关当前状态。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 私网网关跨域标志。
        /// </summary>
        [JsonProperty("CrossDomain")]
        public bool? CrossDomain{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 标签键值对。
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// 专线网关唯一`ID`
        /// </summary>
        [JsonProperty("DirectConnectGatewayIds")]
        public string[] DirectConnectGatewayIds{ get; set; }

        /// <summary>
        /// 私网网关类型
        /// </summary>
        [JsonProperty("NatType")]
        public string NatType{ get; set; }

        /// <summary>
        /// 私网NAT跨域信息
        /// </summary>
        [JsonProperty("CrossDomainInfo")]
        public PrivateNatCrossDomainInfo CrossDomainInfo{ get; set; }

        /// <summary>
        /// 是否VPC型私网网关
        /// </summary>
        [JsonProperty("VpcType")]
        public bool? VpcType{ get; set; }

        /// <summary>
        /// 跨域私网NAT关联的云联网ID	
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatGatewayId", this.NatGatewayId);
            this.SetParamSimple(map, prefix + "NatGatewayName", this.NatGatewayName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CrossDomain", this.CrossDomain);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamArraySimple(map, prefix + "DirectConnectGatewayIds.", this.DirectConnectGatewayIds);
            this.SetParamSimple(map, prefix + "NatType", this.NatType);
            this.SetParamObj(map, prefix + "CrossDomainInfo.", this.CrossDomainInfo);
            this.SetParamSimple(map, prefix + "VpcType", this.VpcType);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
        }
    }
}

