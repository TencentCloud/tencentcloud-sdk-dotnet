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

    public class LocalGateway : AbstractModel
    {
        
        /// <summary>
        /// CDC实例ID
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// VPC实例ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 本地网关实例ID（计划弃用）
        /// </summary>
        [JsonProperty("UniqLocalGwId")]
        public string UniqLocalGwId{ get; set; }

        /// <summary>
        /// 本地网关名称
        /// </summary>
        [JsonProperty("LocalGatewayName")]
        public string LocalGatewayName{ get; set; }

        /// <summary>
        /// 本地网关IP地址
        /// </summary>
        [JsonProperty("LocalGwIp")]
        public string LocalGwIp{ get; set; }

        /// <summary>
        /// 本地网关创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 标签键值对。	
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// 本地网关实例ID（计划起用）
        /// </summary>
        [JsonProperty("LocalGatewayId")]
        public string LocalGatewayId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "UniqLocalGwId", this.UniqLocalGwId);
            this.SetParamSimple(map, prefix + "LocalGatewayName", this.LocalGatewayName);
            this.SetParamSimple(map, prefix + "LocalGwIp", this.LocalGwIp);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "LocalGatewayId", this.LocalGatewayId);
        }
    }
}

