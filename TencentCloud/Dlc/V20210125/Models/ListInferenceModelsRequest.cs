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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListInferenceModelsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>页码（从1开始）</p>
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }

        /// <summary>
        /// <p>每页数量（最大 200）</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// <p>过滤器</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>排序字段</p>
        /// </summary>
        [JsonProperty("SortFields")]
        public SortField[] SortFields{ get; set; }

        /// <summary>
        /// <p>模型参数最小值</p>
        /// </summary>
        [JsonProperty("ParameterSizeMin")]
        public float? ParameterSizeMin{ get; set; }

        /// <summary>
        /// <p>模型参数最大值</p>
        /// </summary>
        [JsonProperty("ParameterSizeMax")]
        public float? ParameterSizeMax{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "SortFields.", this.SortFields);
            this.SetParamSimple(map, prefix + "ParameterSizeMin", this.ParameterSizeMin);
            this.SetParamSimple(map, prefix + "ParameterSizeMax", this.ParameterSizeMax);
        }
    }
}

