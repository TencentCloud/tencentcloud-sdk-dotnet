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

    public class DescribeAlarmNoticesRequest : AbstractModel
    {
        
        /// <summary>
        /// name
        /// 按照【通知渠道组名称】进行过滤。
        /// 类型：String
        /// 示例："Filters":[{"Key":"name","Values":["test-notice"]}]
        /// 必选：否
        /// alarmNoticeId
        /// 按照【通知渠道组ID】进行过滤。
        /// 类型：String
        /// 示例："Filters": [{Key: "alarmNoticeId", Values: ["notice-5281f1d2-6275-4e56-9ec3-a1eb19d8bc2f"]}]
        /// 必选：否
        /// uid
        /// 按照【接收用户ID】进行过滤。
        /// 类型：String
        /// 示例："Filters": [{Key: "uid", Values: ["1137546"]}]
        /// 必选：否
        /// groupId
        /// 按照【接收用户组ID】进行过滤。
        /// 类型：String
        /// 示例："Filters": [{Key: "groupId", Values: ["344098"]}]
        /// 必选：否
        /// 
        /// deliverFlag
        /// 按照【投递状态】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 可选值： "1":未启用,  "2": 已启用, "3":投递异常
        /// 示例："Filters":[{"Key":"deliverFlag","Values":["2"]}]
        /// 每次请求的Filters的上限为10，Filter.Values的上限为5。
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
        /// 是否需要返回通知渠道组配置的告警屏蔽统计状态数量信息。
        /// - true：需要返回；
        /// - false：不返回（默认false）。
        /// </summary>
        [JsonProperty("HasAlarmShieldCount")]
        public bool? HasAlarmShieldCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "HasAlarmShieldCount", this.HasAlarmShieldCount);
        }
    }
}

