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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeListProtectThresholdConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 页起始偏移，取值为(页码-1)*一页条数
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 一页条数，当Limit=0时，默认一页条数为100;最大取值为100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 资源实例ID搜索, 支持资源实例前缀通配搜索，例如bgp-*表示获取高防包类型的资源实例
        /// </summary>
        [JsonProperty("FilterInstanceId")]
        public string FilterInstanceId{ get; set; }

        /// <summary>
        /// IP搜索
        /// </summary>
        [JsonProperty("FilterIp")]
        public string FilterIp{ get; set; }

        /// <summary>
        /// 域名搜索(查询域名与协议的CC防护阈值时使用）
        /// </summary>
        [JsonProperty("FilterDomain")]
        public string FilterDomain{ get; set; }

        /// <summary>
        /// 协议搜索(查询域名与协议的CC防护阈值时使用）
        /// </summary>
        [JsonProperty("FilterProtocol")]
        public string FilterProtocol{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "FilterInstanceId", this.FilterInstanceId);
            this.SetParamSimple(map, prefix + "FilterIp", this.FilterIp);
            this.SetParamSimple(map, prefix + "FilterDomain", this.FilterDomain);
            this.SetParamSimple(map, prefix + "FilterProtocol", this.FilterProtocol);
        }
    }
}

