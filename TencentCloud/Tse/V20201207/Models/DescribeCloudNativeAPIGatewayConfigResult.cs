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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCloudNativeAPIGatewayConfigResult : AbstractModel
    {
        
        /// <summary>
        /// 网关实例ID。
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 分组网络配置列表。
        /// </summary>
        [JsonProperty("ConfigList")]
        public CloudNativeAPIGatewayConfig[] ConfigList{ get; set; }

        /// <summary>
        /// 分组子网信息
        /// </summary>
        [JsonProperty("GroupSubnetId")]
        public string GroupSubnetId{ get; set; }

        /// <summary>
        /// 分组VPC信息
        /// </summary>
        [JsonProperty("GroupVpcId")]
        public string GroupVpcId{ get; set; }

        /// <summary>
        /// 分组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamArrayObj(map, prefix + "ConfigList.", this.ConfigList);
            this.SetParamSimple(map, prefix + "GroupSubnetId", this.GroupSubnetId);
            this.SetParamSimple(map, prefix + "GroupVpcId", this.GroupVpcId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
        }
    }
}

