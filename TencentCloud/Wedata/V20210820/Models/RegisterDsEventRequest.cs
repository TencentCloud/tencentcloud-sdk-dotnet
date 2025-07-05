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

    public class RegisterDsEventRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 事件周期类型 1、分钟：MIN    2、小时 ：HOUR    3、天：DAY	
        /// </summary>
        [JsonProperty("EventSubType")]
        public string EventSubType{ get; set; }

        /// <summary>
        /// 事件存活时间，值为大于0的整数
        /// </summary>
        [JsonProperty("TimeToLive")]
        public string TimeToLive{ get; set; }

        /// <summary>
        /// 事件存活时间单位	1、天：DAYS    2、分钟：MINUTES
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 事件所属人，账号昵称	
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// 事件描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 事件类型GENERAL、TIME_SERIES
        /// </summary>
        [JsonProperty("EventType")]
        [System.Obsolete]
        public string EventType{ get; set; }

        /// <summary>
        /// 事件广播类型SINGLE、BROADCAST	
        /// </summary>
        [JsonProperty("EventBroadcastType")]
        [System.Obsolete]
        public string EventBroadcastType{ get; set; }

        /// <summary>
        /// 时间格式	
        /// </summary>
        [JsonProperty("DimensionFormat")]
        [System.Obsolete]
        public string DimensionFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EventSubType", this.EventSubType);
            this.SetParamSimple(map, prefix + "TimeToLive", this.TimeToLive);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "EventBroadcastType", this.EventBroadcastType);
            this.SetParamSimple(map, prefix + "DimensionFormat", this.DimensionFormat);
        }
    }
}

