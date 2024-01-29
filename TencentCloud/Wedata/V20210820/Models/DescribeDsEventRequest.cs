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

    public class DescribeDsEventRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 事件名称/项目名称
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// 事件类型GENERAL、TIME_SERIES
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// 事件子类型SECOND、MIN、HOUR、DAY
        /// </summary>
        [JsonProperty("EventSubType")]
        public string EventSubType{ get; set; }

        /// <summary>
        /// 日期格式
        /// </summary>
        [JsonProperty("DatetimeFormat")]
        public string DatetimeFormat{ get; set; }

        /// <summary>
        /// 创建开始时间
        /// </summary>
        [JsonProperty("CreationTimeStart")]
        public string CreationTimeStart{ get; set; }

        /// <summary>
        /// 创建结束时间
        /// </summary>
        [JsonProperty("CreationTimeEnd")]
        public string CreationTimeEnd{ get; set; }

        /// <summary>
        /// 排序参数
        /// </summary>
        [JsonProperty("OrderFields")]
        public OrderField[] OrderFields{ get; set; }

        /// <summary>
        /// 责任人筛选
        /// </summary>
        [JsonProperty("OwnerNameList")]
        public string[] OwnerNameList{ get; set; }

        /// <summary>
        /// 任务周期筛选
        /// </summary>
        [JsonProperty("TaskCycleType")]
        public string TaskCycleType{ get; set; }

        /// <summary>
        /// 0表示自定义，其他的表示固定参数，单位为天
        /// </summary>
        [JsonProperty("TimeToLive")]
        public long?[] TimeToLive{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "EventSubType", this.EventSubType);
            this.SetParamSimple(map, prefix + "DatetimeFormat", this.DatetimeFormat);
            this.SetParamSimple(map, prefix + "CreationTimeStart", this.CreationTimeStart);
            this.SetParamSimple(map, prefix + "CreationTimeEnd", this.CreationTimeEnd);
            this.SetParamArrayObj(map, prefix + "OrderFields.", this.OrderFields);
            this.SetParamArraySimple(map, prefix + "OwnerNameList.", this.OwnerNameList);
            this.SetParamSimple(map, prefix + "TaskCycleType", this.TaskCycleType);
            this.SetParamArraySimple(map, prefix + "TimeToLive.", this.TimeToLive);
        }
    }
}

