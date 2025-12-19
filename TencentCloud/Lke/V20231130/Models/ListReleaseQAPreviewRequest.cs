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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListReleaseQAPreviewRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID（获取方法参看如何获取   [BotBizId](https://cloud.tencent.com/document/product/1759/109469#4eecb8c1-6ce4-45f5-8fa2-b269449d8efa)）
        /// </summary>
        [JsonProperty("BotBizId")]
        public string BotBizId{ get; set; }

        /// <summary>
        /// 页码（必须大于0）
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 每页数量（取值范围为1-200）
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 查询内容关键字，用于模糊查询，若未提供该参数，默认为查询全部。
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 发布单ID（可以通过[ListRelease](https://cloud.tencent.com/document/product/1759/105077)获得）
        /// </summary>
        [JsonProperty("ReleaseBizId")]
        public string ReleaseBizId{ get; set; }

        /// <summary>
        /// 开始时间。Unix 时间戳，单位是秒，默认为空。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间。Unix 时间戳，单位是秒，默认为空。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 状态(1新增2修改3删除)，其和ReleaseStatus的区别为：Actions表示的是对数据/内容的操作状态，ReleaseStatus表示数据/内容本身的发布状态
        /// </summary>
        [JsonProperty("Actions")]
        public ulong?[] Actions{ get; set; }

        /// <summary>
        /// 发布状态(4发布成功5发布失败)。其和Actions的区别为：Actions表示的是对数据/内容的操作状态，ReleaseStatus表示数据/内容本身的发布状态
        /// </summary>
        [JsonProperty("ReleaseStatus")]
        public ulong?[] ReleaseStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "ReleaseBizId", this.ReleaseBizId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "Actions.", this.Actions);
            this.SetParamArraySimple(map, prefix + "ReleaseStatus.", this.ReleaseStatus);
        }
    }
}

