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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BillingData : AbstractModel
    {
        
        /// <summary>
        /// 数据时间戳。
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 数值。
        /// </summary>
        [JsonProperty("Value")]
        public ulong? Value{ get; set; }

        /// <summary>
        /// 数据点所属站点 ID。若使用内容标识符功能，则该项值为内容标识符。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 数据点所属域名。
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 数据点所属四层代理实例 ID。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 数据点所属计费大区 ID。计费大区以实际服务用户客户端的 EdgeOne 节点所在区域为准。取值有：<li>CH：中国大陆境内</li><li>AF：非洲</li><li>AS1：亚太一区</li><li>AS2：亚太二区</li><li>AS3：亚太三区</li><li>EU：欧洲</li><li>MidEast：中东</li><li>NA：北美</li><li> SA：南美</li>
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
        }
    }
}

