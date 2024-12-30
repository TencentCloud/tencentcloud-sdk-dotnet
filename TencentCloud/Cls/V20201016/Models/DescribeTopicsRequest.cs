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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTopicsRequest : AbstractModel
    {
        
        /// <summary>
        /// <ul><li>topicName 按照【日志主题名称】进行过滤，默认为模糊匹配，可使用 PreciseSearch 参数设置为精确匹配。类型：String。必选：否</li>
        /// <li>logsetName 按照【日志集名称】进行过滤，默认为模糊匹配，可使用 PreciseSearch 参数设置为精确匹配。类型：String。必选：否</li>
        /// <li>topicId 按照【日志主题ID】进行过滤。类型：String。必选：否</li>
        /// <li>logsetId 按照【日志集ID】进行过滤，可通过调用 DescribeLogsets 查询已创建的日志集列表或登录控制台进行查看；也可以调用 CreateLogset 创建新的日志集。类型：String。必选：否</li>
        /// <li>tagKey 按照【标签键】进行过滤。类型：String。必选：否</li>
        /// <li>tag:tagKey 按照【标签键值对】进行过滤。tagKey 使用具体的标签键进行替换，例如 tag:exampleKey。类型：String。必选：否</li>
        /// <li>storageType 按照【日志主题的存储类型】进行过滤。可选值 hot（标准存储），cold（低频存储）类型：String。必选：否</li></ul>
        /// 注意：每次请求的 Filters 的上限为10，Filter.Values 的上限为100。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 分页的偏移量，默认值为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页单页限制数目，默认值为20，最大值100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 控制Filters相关字段是否为精确匹配。
        /// <ul><li>0: 默认值，topicName 和 logsetName 模糊匹配</li>
        /// <li>1: topicName   精确匹配</li>
        /// <li>2: logsetName精确匹配</li>
        /// <li>3: topicName 和logsetName 都精确匹配</li></ul>
        /// </summary>
        [JsonProperty("PreciseSearch")]
        public ulong? PreciseSearch{ get; set; }

        /// <summary>
        /// 主题类型
        /// - 0:日志主题，默认值
        /// - 1:指标主题
        /// </summary>
        [JsonProperty("BizType")]
        public ulong? BizType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "PreciseSearch", this.PreciseSearch);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
        }
    }
}

