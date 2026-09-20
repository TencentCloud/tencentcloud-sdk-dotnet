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

    public class DescribeSessionsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>查询的会话空间 ID。</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// <p>Agent ID 列表，最多支持 100 个。</p>
        /// </summary>
        [JsonProperty("AgentIds")]
        [System.Obsolete]
        public string[] AgentIds{ get; set; }

        /// <summary>
        /// <p>用户 ID 列表，最多支持 100 个。</p>
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// <p>分页偏移量，默认为 0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>返回数量，默认为 20，最大值为 100。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>会话 ID 列表，最多支持 100 个。</p>
        /// </summary>
        [JsonProperty("SessionIds")]
        public string[] SessionIds{ get; set; }

        /// <summary>
        /// <p>会话筛选条件列表，支持 Metadata 精确匹配、标题精确匹配和标题模糊匹配。同一 Filter 内多个 Values 之间为 OR，不同 Filter 之间为 AND。不传或传空数组时不增加筛选限制。</p><p>入参限制：最多传入 10 个 Filter，每个 Filter 最多支持 100 个 Values。Filter.Name 不可重复，支持 metadata:MetadataKey、title、title-like；title 与 title-like 不可同时提供。标题筛选值不可为空或纯空白。匹配区分大小写，标题包含匹配中的 %、_ 按普通字符处理，不具有通配含义。</p><p>例如 Name 为 title-like，Values 为 [&quot;客服&quot;,&quot;测试&quot;]，表示查询标题包含“客服”或“测试”的会话。Name 为 metadata:env，Values 为 [&quot;dev&quot;,&quot;test&quot;]，表示按 Metadata env 的值精确筛选。标题条件与 Metadata、SessionIds、UserIds 筛选条件可组合使用，条件之间为 AND。筛选在分页前执行，TotalCount 为符合条件的会话总数。</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamArraySimple(map, prefix + "AgentIds.", this.AgentIds);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "SessionIds.", this.SessionIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

