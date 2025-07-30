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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMachinesRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询的机器组ID。
        /// 
        /// - 通过[获取机器组列表](https://cloud.tencent.com/document/api/614/56438)获取机器组ID。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// ip
        /// - 按照ip进行过滤。
        /// - 类型：String
        /// - 必选：否
        /// 
        /// instance
        /// - 按照实例id进行过滤。
        /// - 类型：String
        /// - 必选：否
        /// 
        /// version
        /// - 按照LogListener版本进行过滤。
        /// - 类型：String
        /// - 必选：否
        /// 
        /// status
        /// - 按照机器状态进行过滤。
        /// - 类型：String
        /// - 必选：否
        /// - 可选值：0：离线，1：正常
        /// 
        /// offlineTime
        /// - 按照机器离线时间进行过滤。
        /// - 类型：String
        /// - 必选：否
        /// - -可选值：0：无离线时间，12：12小时内，24：一天内，48：两天内，99：两天前
        /// 
        /// 每次请求的Filters的上限为10，Filter.Values的上限为100。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 分页的偏移量。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 分页单页限制数目。最大支持100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

