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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SalesActionEventDetail : AbstractModel
    {
        
        /// <summary>
        /// 事件码
        /// </summary>
        [JsonProperty("EventCode")]
        public string EventCode{ get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [JsonProperty("EventType")]
        public long? EventType{ get; set; }

        /// <summary>
        /// 事件来源
        /// </summary>
        [JsonProperty("EventSource")]
        public long? EventSource{ get; set; }

        /// <summary>
        /// 销售顾问id
        /// </summary>
        [JsonProperty("SalesId")]
        public ulong? SalesId{ get; set; }

        /// <summary>
        /// 素材类型
        /// </summary>
        [JsonProperty("MaterialType")]
        public long? MaterialType{ get; set; }

        /// <summary>
        /// 素材编号id
        /// </summary>
        [JsonProperty("MaterialId")]
        public ulong? MaterialId{ get; set; }

        /// <summary>
        /// 事件上报时间，单位：秒
        /// </summary>
        [JsonProperty("EventTime")]
        public ulong? EventTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventCode", this.EventCode);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "EventSource", this.EventSource);
            this.SetParamSimple(map, prefix + "SalesId", this.SalesId);
            this.SetParamSimple(map, prefix + "MaterialType", this.MaterialType);
            this.SetParamSimple(map, prefix + "MaterialId", this.MaterialId);
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
        }
    }
}

