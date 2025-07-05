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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DirectConnectTunnelRoute : AbstractModel
    {
        
        /// <summary>
        /// 专用通道路由ID
        /// </summary>
        [JsonProperty("RouteId")]
        public string RouteId{ get; set; }

        /// <summary>
        /// 网段CIDR
        /// </summary>
        [JsonProperty("DestinationCidrBlock")]
        public string DestinationCidrBlock{ get; set; }

        /// <summary>
        /// 路由类型：BGP/STATIC路由
        /// </summary>
        [JsonProperty("RouteType")]
        public string RouteType{ get; set; }

        /// <summary>
        /// ENABLE：路由启用，DISABLE：路由禁用
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// ASPath信息
        /// </summary>
        [JsonProperty("ASPath")]
        public string[] ASPath{ get; set; }

        /// <summary>
        /// 路由下一跳IP
        /// </summary>
        [JsonProperty("NextHop")]
        public string NextHop{ get; set; }

        /// <summary>
        /// 路由更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 是否配置在通道上
        /// </summary>
        [JsonProperty("ApplyOnTunnelEnable")]
        public bool? ApplyOnTunnelEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RouteId", this.RouteId);
            this.SetParamSimple(map, prefix + "DestinationCidrBlock", this.DestinationCidrBlock);
            this.SetParamSimple(map, prefix + "RouteType", this.RouteType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "ASPath.", this.ASPath);
            this.SetParamSimple(map, prefix + "NextHop", this.NextHop);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ApplyOnTunnelEnable", this.ApplyOnTunnelEnable);
        }
    }
}

