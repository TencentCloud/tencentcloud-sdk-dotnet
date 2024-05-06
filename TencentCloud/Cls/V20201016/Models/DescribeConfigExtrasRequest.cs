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

    public class DescribeConfigExtrasRequest : AbstractModel
    {
        
        /// <summary>
        /// name
        /// - 按照【特殊采集配置名称】进行模糊匹配过滤。
        /// - 类型：String
        /// - 必选：否
        /// 
        /// configExtraId
        /// - 按照【特殊采集配置ID】进行过滤。
        /// - 类型：String
        /// - 必选：否
        /// 
        /// topicId
        /// - 按照【日志主题】进行过滤。
        /// - 类型：String
        /// - 必选：否
        /// 
        /// machineGroupId
        /// - 按照【机器组ID】进行过滤。
        /// - 类型：String
        /// - 必选：否
        /// 
        /// 每次请求的Filters的上限为10，Filter.Values的上限为5。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 分页的偏移量，默认值为0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 分页单页的限制数目，默认值为20，最大值100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

