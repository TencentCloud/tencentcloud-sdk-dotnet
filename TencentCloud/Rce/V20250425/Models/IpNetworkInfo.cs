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

namespace TencentCloud.Rce.V20250425.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IpNetworkInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>互联网服务提供商</p>
        /// </summary>
        [JsonProperty("ISP")]
        public string ISP{ get; set; }

        /// <summary>
        /// <p>自治系统号</p>
        /// </summary>
        [JsonProperty("ASN")]
        public string ASN{ get; set; }

        /// <summary>
        /// <p>IP注册组织名称</p>
        /// </summary>
        [JsonProperty("Organization")]
        public string Organization{ get; set; }

        /// <summary>
        /// <p>是否保留IP</p>
        /// </summary>
        [JsonProperty("IsReserved")]
        public bool? IsReserved{ get; set; }

        /// <summary>
        /// <p>是否网关IP</p>
        /// </summary>
        [JsonProperty("IsGateway")]
        public bool? IsGateway{ get; set; }

        /// <summary>
        /// <p>是否任播网络</p>
        /// </summary>
        [JsonProperty("IsAnycast")]
        public bool? IsAnycast{ get; set; }

        /// <summary>
        /// <p>是否移动网络</p>
        /// </summary>
        [JsonProperty("IsMobile")]
        public bool? IsMobile{ get; set; }

        /// <summary>
        /// <p>是否动态IP</p>
        /// </summary>
        [JsonProperty("IsDynamic")]
        public bool? IsDynamic{ get; set; }

        /// <summary>
        /// <p>是否网络出口</p>
        /// </summary>
        [JsonProperty("IsEgress")]
        public bool? IsEgress{ get; set; }

        /// <summary>
        /// <p>是否域名解析</p>
        /// </summary>
        [JsonProperty("IsDNS")]
        public bool? IsDNS{ get; set; }

        /// <summary>
        /// <p>是否教育机构</p>
        /// </summary>
        [JsonProperty("IsEducation")]
        public bool? IsEducation{ get; set; }

        /// <summary>
        /// <p>是否组织机构</p>
        /// </summary>
        [JsonProperty("IsInstitution")]
        public bool? IsInstitution{ get; set; }

        /// <summary>
        /// <p>是否企业专线</p>
        /// </summary>
        [JsonProperty("IsCompany")]
        public bool? IsCompany{ get; set; }

        /// <summary>
        /// <p>是否家用宽带</p>
        /// </summary>
        [JsonProperty("IsResidence")]
        public bool? IsResidence{ get; set; }

        /// <summary>
        /// <p>是否云服务</p>
        /// </summary>
        [JsonProperty("IsCloudService")]
        public bool? IsCloudService{ get; set; }

        /// <summary>
        /// <p>是否基础设施</p>
        /// </summary>
        [JsonProperty("IsInfrastructure")]
        public bool? IsInfrastructure{ get; set; }

        /// <summary>
        /// <p>是否邮箱服务</p>
        /// </summary>
        [JsonProperty("IsMXServer")]
        public bool? IsMXServer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ISP", this.ISP);
            this.SetParamSimple(map, prefix + "ASN", this.ASN);
            this.SetParamSimple(map, prefix + "Organization", this.Organization);
            this.SetParamSimple(map, prefix + "IsReserved", this.IsReserved);
            this.SetParamSimple(map, prefix + "IsGateway", this.IsGateway);
            this.SetParamSimple(map, prefix + "IsAnycast", this.IsAnycast);
            this.SetParamSimple(map, prefix + "IsMobile", this.IsMobile);
            this.SetParamSimple(map, prefix + "IsDynamic", this.IsDynamic);
            this.SetParamSimple(map, prefix + "IsEgress", this.IsEgress);
            this.SetParamSimple(map, prefix + "IsDNS", this.IsDNS);
            this.SetParamSimple(map, prefix + "IsEducation", this.IsEducation);
            this.SetParamSimple(map, prefix + "IsInstitution", this.IsInstitution);
            this.SetParamSimple(map, prefix + "IsCompany", this.IsCompany);
            this.SetParamSimple(map, prefix + "IsResidence", this.IsResidence);
            this.SetParamSimple(map, prefix + "IsCloudService", this.IsCloudService);
            this.SetParamSimple(map, prefix + "IsInfrastructure", this.IsInfrastructure);
            this.SetParamSimple(map, prefix + "IsMXServer", this.IsMXServer);
        }
    }
}

