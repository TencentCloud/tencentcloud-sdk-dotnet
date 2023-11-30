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

    public class DescribeEventCasesRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 事件实例目录,示例取值:
        /// - 已过期: expired
        /// - 未过期: consuming
        /// - 全部: all
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 每页数目
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [JsonProperty("EventType")]
        [System.Obsolete]
        public string EventType{ get; set; }

        /// <summary>
        /// 事件分割类型
        /// </summary>
        [JsonProperty("EventSubType")]
        public string EventSubType{ get; set; }

        /// <summary>
        /// 事件广播类型
        /// </summary>
        [JsonProperty("EventBroadcastType")]
        [System.Obsolete]
        public string EventBroadcastType{ get; set; }

        /// <summary>
        /// 事件实例状态,示例取值:
        /// - 已消费: COMSUMED
        /// - 已过期: EXPIRED
        /// - 待消费: ACTIVE
        /// - 消费中: CONSUMING
        /// </summary>
        [JsonProperty("Status")]
        [System.Obsolete]
        public string Status{ get; set; }

        /// <summary>
        /// 事件实例最小创建时间
        /// </summary>
        [JsonProperty("CreationTimeStart")]
        public string CreationTimeStart{ get; set; }

        /// <summary>
        /// 事件实例最大创建时间
        /// </summary>
        [JsonProperty("CreationTimeEnd")]
        public string CreationTimeEnd{ get; set; }

        /// <summary>
        /// 事件实例最小触发时间
        /// </summary>
        [JsonProperty("EventTriggeredTimeStart")]
        public string EventTriggeredTimeStart{ get; set; }

        /// <summary>
        /// 事件实例最大触发时间
        /// </summary>
        [JsonProperty("EventTriggeredTimeEnd")]
        public string EventTriggeredTimeEnd{ get; set; }

        /// <summary>
        /// 事件实例最小消费时间
        /// </summary>
        [JsonProperty("LogTimeStart")]
        public string LogTimeStart{ get; set; }

        /// <summary>
        /// 事件实例最大消费时间
        /// </summary>
        [JsonProperty("LogTimeEnd")]
        public string LogTimeEnd{ get; set; }

        /// <summary>
        /// 事件实例数据时间
        /// </summary>
        [JsonProperty("Dimension")]
        public string Dimension{ get; set; }

        /// <summary>
        /// 事件实例有效时间
        /// </summary>
        [JsonProperty("TimeToLive")]
        public string TimeToLive{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("SortItem")]
        public string SortItem{ get; set; }

        /// <summary>
        /// 排序顺序
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "EventSubType", this.EventSubType);
            this.SetParamSimple(map, prefix + "EventBroadcastType", this.EventBroadcastType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreationTimeStart", this.CreationTimeStart);
            this.SetParamSimple(map, prefix + "CreationTimeEnd", this.CreationTimeEnd);
            this.SetParamSimple(map, prefix + "EventTriggeredTimeStart", this.EventTriggeredTimeStart);
            this.SetParamSimple(map, prefix + "EventTriggeredTimeEnd", this.EventTriggeredTimeEnd);
            this.SetParamSimple(map, prefix + "LogTimeStart", this.LogTimeStart);
            this.SetParamSimple(map, prefix + "LogTimeEnd", this.LogTimeEnd);
            this.SetParamSimple(map, prefix + "Dimension", this.Dimension);
            this.SetParamSimple(map, prefix + "TimeToLive", this.TimeToLive);
            this.SetParamSimple(map, prefix + "SortItem", this.SortItem);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
        }
    }
}

