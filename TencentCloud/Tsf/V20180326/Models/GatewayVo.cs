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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GatewayVo : AbstractModel
    {
        
        /// <summary>
        /// 网关部署组ID
        /// </summary>
        [JsonProperty("GatewayDeployGroupId")]
        public string GatewayDeployGroupId{ get; set; }

        /// <summary>
        /// 网关部署组名称
        /// </summary>
        [JsonProperty("GatewayDeployGroupName")]
        public string GatewayDeployGroupName{ get; set; }

        /// <summary>
        /// API 分组个数
        /// </summary>
        [JsonProperty("GroupNum")]
        public ulong? GroupNum{ get; set; }

        /// <summary>
        /// API 分组列表
        /// </summary>
        [JsonProperty("Groups")]
        public GatewayApiGroupVo[] Groups{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayDeployGroupId", this.GatewayDeployGroupId);
            this.SetParamSimple(map, prefix + "GatewayDeployGroupName", this.GatewayDeployGroupName);
            this.SetParamSimple(map, prefix + "GroupNum", this.GroupNum);
            this.SetParamArrayObj(map, prefix + "Groups.", this.Groups);
        }
    }
}

