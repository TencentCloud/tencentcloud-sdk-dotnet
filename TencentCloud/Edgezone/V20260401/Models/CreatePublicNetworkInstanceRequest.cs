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

namespace TencentCloud.Edgezone.V20260401.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePublicNetworkInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>可用区</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>公网实例名称</p>
        /// </summary>
        [JsonProperty("NetworkInstanceName")]
        public string NetworkInstanceName{ get; set; }

        /// <summary>
        /// <p>网络线路</p>
        /// </summary>
        [JsonProperty("Line")]
        public string Line{ get; set; }

        /// <summary>
        /// <p>路由模式</p>
        /// </summary>
        [JsonProperty("RouteMode")]
        public string RouteMode{ get; set; }

        /// <summary>
        /// <p>公网带宽（Mbps）</p>
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// <p>BGP AS号</p>
        /// </summary>
        [JsonProperty("BgpAsNumber")]
        public long? BgpAsNumber{ get; set; }

        /// <summary>
        /// <p>BGP认证密码</p>
        /// </summary>
        [JsonProperty("BgpPassword")]
        public string BgpPassword{ get; set; }

        /// <summary>
        /// <p>公网实例类型</p><p>枚举值：</p><ul><li>standard： 标准型(默认)</li><li>custom： 自定义型(暂不支持创建)</li></ul>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "NetworkInstanceName", this.NetworkInstanceName);
            this.SetParamSimple(map, prefix + "Line", this.Line);
            this.SetParamSimple(map, prefix + "RouteMode", this.RouteMode);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "BgpAsNumber", this.BgpAsNumber);
            this.SetParamSimple(map, prefix + "BgpPassword", this.BgpPassword);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
        }
    }
}

