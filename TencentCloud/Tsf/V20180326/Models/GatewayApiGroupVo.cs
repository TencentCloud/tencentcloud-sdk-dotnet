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

    public class GatewayApiGroupVo : AbstractModel
    {
        
        /// <summary>
        /// 分组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 分组下API个数
        /// </summary>
        [JsonProperty("GroupApiCount")]
        public ulong? GroupApiCount{ get; set; }

        /// <summary>
        /// 分组API列表
        /// </summary>
        [JsonProperty("GroupApis")]
        public GatewayGroupApiVo[] GroupApis{ get; set; }

        /// <summary>
        /// 网关实例的类型
        /// </summary>
        [JsonProperty("GatewayInstanceType")]
        public string GatewayInstanceType{ get; set; }

        /// <summary>
        /// 网关实例ID
        /// </summary>
        [JsonProperty("GatewayInstanceId")]
        public string GatewayInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupApiCount", this.GroupApiCount);
            this.SetParamArrayObj(map, prefix + "GroupApis.", this.GroupApis);
            this.SetParamSimple(map, prefix + "GatewayInstanceType", this.GatewayInstanceType);
            this.SetParamSimple(map, prefix + "GatewayInstanceId", this.GatewayInstanceId);
        }
    }
}

