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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloneTaskModePageInfoInfo : AbstractModel
    {
        
        /// <summary>
        /// item 总数量
        /// </summary>
        [JsonProperty("TotalItems")]
        public ulong? TotalItems{ get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonProperty("TotalPages")]
        public ulong? TotalPages{ get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonProperty("CurrentPage")]
        public ulong? CurrentPage{ get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 当前页实际 item 数量
        /// </summary>
        [JsonProperty("CurrentPageItems")]
        public ulong? CurrentPageItems{ get; set; }

        /// <summary>
        /// 任务列表信息-项目克隆
        /// </summary>
        [JsonProperty("Items")]
        public CloneTaskModeInfo[] Items{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalItems", this.TotalItems);
            this.SetParamSimple(map, prefix + "TotalPages", this.TotalPages);
            this.SetParamSimple(map, prefix + "CurrentPage", this.CurrentPage);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "CurrentPageItems", this.CurrentPageItems);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
        }
    }
}

