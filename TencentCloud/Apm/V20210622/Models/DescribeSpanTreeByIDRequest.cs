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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSpanTreeByIDRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>业务系统 ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>TraceID</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>Span查询开始时间戳（单位:秒）</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>Span查询结束时间戳（单位:秒）</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>代表请求的是否为完整瀑布图</p>
        /// </summary>
        [JsonProperty("IsFold")]
        public bool? IsFold{ get; set; }

        /// <summary>
        /// <p>开启关键调用视图</p>
        /// </summary>
        [JsonProperty("EntrySpanSelected")]
        public bool? EntrySpanSelected{ get; set; }

        /// <summary>
        /// <p>关注的SpanId</p>
        /// </summary>
        [JsonProperty("FocusSpanId")]
        public string FocusSpanId{ get; set; }

        /// <summary>
        /// <p>过滤视图的Tag列表</p>
        /// </summary>
        [JsonProperty("FilterViewTagKeyList")]
        public string[] FilterViewTagKeyList{ get; set; }

        /// <summary>
        /// <p>是否开启云资源关联</p>
        /// </summary>
        [JsonProperty("EnableResourceLink")]
        public bool? EnableResourceLink{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "IsFold", this.IsFold);
            this.SetParamSimple(map, prefix + "EntrySpanSelected", this.EntrySpanSelected);
            this.SetParamSimple(map, prefix + "FocusSpanId", this.FocusSpanId);
            this.SetParamArraySimple(map, prefix + "FilterViewTagKeyList.", this.FilterViewTagKeyList);
            this.SetParamSimple(map, prefix + "EnableResourceLink", this.EnableResourceLink);
        }
    }
}

