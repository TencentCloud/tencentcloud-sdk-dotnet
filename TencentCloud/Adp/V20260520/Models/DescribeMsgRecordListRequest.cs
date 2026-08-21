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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMsgRecordListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用 ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>过滤条件列表，支持：ChannelType（渠道类型，0 全部）、FeedbackType（反馈类型，-1 为全部）、QueryType、Query、CategoryId、ReplyMethod、StartTime、EndTime（秒时间戳）、Cursor（游标信息，上一页取响应 PrevCursor，下一页取响应 NextCursor）、Direction（方向，next 下一页，prev 上一页）、CallResult（调用结果，默认 0 为全部，1 为成功，2 为失败）、FailReason、Intent</p>
        /// </summary>
        [JsonProperty("FilterList")]
        public Filter[] FilterList{ get; set; }

        /// <summary>
        /// <p>页码，从 0 开始；不传时按 0 处理</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// <p>每页数量，最大 100；不传或传 0 时按默认分页大小处理</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// <p>排序条件，只支持按 CreateTime 排序</p>
        /// </summary>
        [JsonProperty("Sort")]
        public Sort Sort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamArrayObj(map, prefix + "FilterList.", this.FilterList);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
        }
    }
}

