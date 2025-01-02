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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventLog : AbstractModel
    {
        
        /// <summary>
        /// 事件通道，支持Application，Security，Setup，System，ALL
        /// </summary>
        [JsonProperty("EventChannel")]
        public string EventChannel{ get; set; }

        /// <summary>
        /// 时间类型，1:用户自定义，2:当前时间
        /// </summary>
        [JsonProperty("TimeType")]
        public ulong? TimeType{ get; set; }

        /// <summary>
        /// 时间，用户选择自定义时间类型时，需要指定时间
        /// </summary>
        [JsonProperty("Timestamp")]
        public ulong? Timestamp{ get; set; }

        /// <summary>
        /// 事件ID过滤列表
        /// 	
        /// 选填，为空表示不做过滤
        /// 支持正向过滤单个值（例：20）或范围（例：0-20），也支持反向过滤单个值(例：-20)
        /// 多个过滤项之间可由逗号隔开，例：1-200,-100表示采集1-200范围内除了100以外的事件日志
        /// </summary>
        [JsonProperty("EventIDs")]
        public string[] EventIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventChannel", this.EventChannel);
            this.SetParamSimple(map, prefix + "TimeType", this.TimeType);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamArraySimple(map, prefix + "EventIDs.", this.EventIDs);
        }
    }
}

