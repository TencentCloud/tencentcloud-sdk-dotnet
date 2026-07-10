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

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVasListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>偏移量，默认值为0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>限制数量，默认值为20。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>域名ID</p>
        /// </summary>
        [JsonProperty("DomainId")]
        public ulong? DomainId{ get; set; }

        /// <summary>
        /// <p>使用资源 ID 列表查询</p>
        /// </summary>
        [JsonProperty("ResourceIdList")]
        public string[] ResourceIdList{ get; set; }

        /// <summary>
        /// <p>增值服务类型</p>
        /// </summary>
        [JsonProperty("LimitType")]
        public string LimitType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamArraySimple(map, prefix + "ResourceIdList.", this.ResourceIdList);
            this.SetParamSimple(map, prefix + "LimitType", this.LimitType);
        }
    }
}

