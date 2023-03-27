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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBoardSDKLogRequest : AbstractModel
    {
        
        /// <summary>
        /// 白板应用的SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 需要查询日志的白板房间号
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// 需要查询日志的用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 查询时间段，Unix时间戳，单位毫秒，第一个值为开始时间戳，第二个值为结束时间
        /// </summary>
        [JsonProperty("TimeRange")]
        public long?[] TimeRange{ get; set; }

        /// <summary>
        /// 聚合日志条数查询的桶的时间范围，如5m, 1h, 4h等
        /// </summary>
        [JsonProperty("AggregationInterval")]
        public string AggregationInterval{ get; set; }

        /// <summary>
        /// 额外的查询条件
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 是否按时间升序排列
        /// </summary>
        [JsonProperty("Ascending")]
        public bool? Ascending{ get; set; }

        /// <summary>
        /// 用于递归拉取的上下文Key，在上一次请求中返回
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamArraySimple(map, prefix + "TimeRange.", this.TimeRange);
            this.SetParamSimple(map, prefix + "AggregationInterval", this.AggregationInterval);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "Ascending", this.Ascending);
            this.SetParamSimple(map, prefix + "Context", this.Context);
        }
    }
}

