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

namespace TencentCloud.Cloudaudit.V20190319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始时间戳（单位秒，不超过当前时间 90 天）
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 结束时间戳（单位秒，查询时间跨度小于 30 天）
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 查看更多日志的凭证
        /// </summary>
        [JsonProperty("NextToken")]
        public ulong? NextToken{ get; set; }

        /// <summary>
        /// 返回日志的最大条数（最大 50 条）
        /// </summary>
        [JsonProperty("MaxResults")]
        public ulong? MaxResults{ get; set; }

        /// <summary>
        /// 检索条件（目前支持 RequestId：请求 ID、EventName：事件名称、ActionType：操作类型（Write：写；Read：读）、PrincipalId：子账号、ResourceType：资源类型、ResourceName：资源名称、AccessKeyId：密钥 ID、SensitiveAction：是否敏感操作、ApiErrorCode：API 错误码、CamErrorCode：CAM 错误码、Tags：标签（AttributeValue格式：[{"key":"*","value":"*"}]）备注:检索的各个条件间是与的关系,EventName传多个值内部是或的关系）
        /// </summary>
        [JsonProperty("LookupAttributes")]
        public LookupAttribute[] LookupAttributes{ get; set; }

        /// <summary>
        /// 是否返回 IP 归属地（1 返回，0 不返回）
        /// </summary>
        [JsonProperty("IsReturnLocation")]
        public ulong? IsReturnLocation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamArrayObj(map, prefix + "LookupAttributes.", this.LookupAttributes);
            this.SetParamSimple(map, prefix + "IsReturnLocation", this.IsReturnLocation);
        }
    }
}

