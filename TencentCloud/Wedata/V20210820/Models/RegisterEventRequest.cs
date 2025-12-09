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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegisterEventRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 事件名称，支持英文、数字和下划线，最长20个字符, 不能以数字下划线开头。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 事件分割类型，周期类型: DAY，HOUR，MIN，SECOND
        /// </summary>
        [JsonProperty("EventSubType")]
        public string EventSubType{ get; set; }

        /// <summary>
        /// 广播：BROADCAST,单播：SINGLE
        /// </summary>
        [JsonProperty("EventBroadcastType")]
        public string EventBroadcastType{ get; set; }

        /// <summary>
        /// 周期类型为天和小时为HOURS ，周期类型为分钟 ：MINUTES,周期类型为秒：SECONDS
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 事件所属人
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// 事件类型，不填会使用默认值 TIME_SERIES 填充
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// 对应day： yyyyMMdd，对应HOUR：yyyyMMddHH，对应MIN：yyyyMMddHHmm，对应SECOND：yyyyMMddHHmmss，默认值：yyyyMMdd
        /// </summary>
        [JsonProperty("DimensionFormat")]
        public string DimensionFormat{ get; set; }

        /// <summary>
        /// 存活时间
        /// </summary>
        [JsonProperty("TimeToLive")]
        public long? TimeToLive{ get; set; }

        /// <summary>
        /// 事件描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EventSubType", this.EventSubType);
            this.SetParamSimple(map, prefix + "EventBroadcastType", this.EventBroadcastType);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "DimensionFormat", this.DimensionFormat);
            this.SetParamSimple(map, prefix + "TimeToLive", this.TimeToLive);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

