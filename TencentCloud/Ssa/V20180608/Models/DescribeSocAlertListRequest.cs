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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSocAlertListRequest : AbstractModel
    {
        
        /// <summary>
        /// 页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageIndex")]
        public long? PageIndex{ get; set; }

        /// <summary>
        /// 1:急需关注 2.重保监控 3.全量告警
        /// </summary>
        [JsonProperty("Scenes")]
        public long? Scenes{ get; set; }

        /// <summary>
        /// 查询参数
        /// </summary>
        [JsonProperty("Filter")]
        public QueryFilter[] Filter{ get; set; }

        /// <summary>
        /// 排序参数
        /// </summary>
        [JsonProperty("Sorter")]
        public QuerySort[] Sorter{ get; set; }

        /// <summary>
        /// 是否导出；默认为否，如量级超过1000，则使用单独的导出接口
        /// </summary>
        [JsonProperty("ExportFlag")]
        public bool? ExportFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
            this.SetParamSimple(map, prefix + "Scenes", this.Scenes);
            this.SetParamArrayObj(map, prefix + "Filter.", this.Filter);
            this.SetParamArrayObj(map, prefix + "Sorter.", this.Sorter);
            this.SetParamSimple(map, prefix + "ExportFlag", this.ExportFlag);
        }
    }
}

