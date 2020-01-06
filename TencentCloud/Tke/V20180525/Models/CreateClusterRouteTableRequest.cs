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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClusterRouteTableRequest : AbstractModel
    {
        
        /// <summary>
        /// 路由表名称
        /// </summary>
        [JsonProperty("RouteTableName")]
        public string RouteTableName{ get; set; }

        /// <summary>
        /// 路由表CIDR
        /// </summary>
        [JsonProperty("RouteTableCidrBlock")]
        public string RouteTableCidrBlock{ get; set; }

        /// <summary>
        /// 路由表绑定的VPC
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 是否忽略CIDR冲突
        /// </summary>
        [JsonProperty("IgnoreClusterCidrConflict")]
        public long? IgnoreClusterCidrConflict{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RouteTableName", this.RouteTableName);
            this.SetParamSimple(map, prefix + "RouteTableCidrBlock", this.RouteTableCidrBlock);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "IgnoreClusterCidrConflict", this.IgnoreClusterCidrConflict);
        }
    }
}

