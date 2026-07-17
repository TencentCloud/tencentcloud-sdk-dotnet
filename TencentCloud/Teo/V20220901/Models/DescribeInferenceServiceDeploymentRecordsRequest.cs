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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInferenceServiceDeploymentRecordsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>站点 ID。</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>推理服务 ID。</p>
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// <p>排序字段，取值有：<li>create-time：部署创建时间。</li>默认值为：create-time。</p>
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// <p>排序方式，取值有：<li>asc：升序方式；</li><li>desc：降序方式。</li>默认值为：desc。</p>
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }

        /// <summary>
        /// <p>分页偏移量，默认值：0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>返回记录条数，默认值：20，最大值：100。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

