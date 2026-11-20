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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePreCacheImageCleanupPolicyListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>策略 ID 列表</p><p>入参限制：最多 100 个，每个 1～64 字符；指定时 Offset、Limit、Filters 不生效，不存在或已删除的 ID 被忽略</p>
        /// </summary>
        [JsonProperty("CleanupPolicyIds")]
        public string[] CleanupPolicyIds{ get; set; }

        /// <summary>
        /// <p>过滤器</p><p>入参限制：Filter={Name:String,Values:String[]}；最多 10 个 Filter，每个 Filter 的 Name 和 Values 必填，Values 最多 10 个、每个最多 255 字符</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>偏移值</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>返回数量限制</p><p>取值范围：[1, 100]</p><p>默认值：20</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "CleanupPolicyIds.", this.CleanupPolicyIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

