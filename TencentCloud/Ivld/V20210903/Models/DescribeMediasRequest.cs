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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMediasRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页序号，从1开始
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 每个分页所包含的元素数量，最大为50
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 列举过滤条件，相关限制相见MediaFilter
        /// </summary>
        [JsonProperty("MediaFilter")]
        public MediaFilter MediaFilter{ get; set; }

        /// <summary>
        /// 返回结果排序信息，By字段只支持CreateTime
        /// </summary>
        [JsonProperty("SortBy")]
        public SortBy SortBy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamObj(map, prefix + "MediaFilter.", this.MediaFilter);
            this.SetParamObj(map, prefix + "SortBy.", this.SortBy);
        }
    }
}

