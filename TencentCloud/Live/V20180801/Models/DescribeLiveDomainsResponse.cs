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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLiveDomainsResponse : AbstractModel
    {
        
        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("AllCount")]
        public ulong? AllCount{ get; set; }

        /// <summary>
        /// 域名详细信息列表。
        /// </summary>
        [JsonProperty("DomainList")]
        public DomainInfo[] DomainList{ get; set; }

        /// <summary>
        /// 可继续添加域名数量。
        /// </summary>
        [JsonProperty("CreateLimitCount")]
        public long? CreateLimitCount{ get; set; }

        /// <summary>
        /// 启用的播放域名加速区域统计，数组元素分别为：中国大陆（境内），全球地区，国际/港澳台（境外）域名数量。
        /// </summary>
        [JsonProperty("PlayTypeCount")]
        public long?[] PlayTypeCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllCount", this.AllCount);
            this.SetParamArrayObj(map, prefix + "DomainList.", this.DomainList);
            this.SetParamSimple(map, prefix + "CreateLimitCount", this.CreateLimitCount);
            this.SetParamArraySimple(map, prefix + "PlayTypeCount.", this.PlayTypeCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

