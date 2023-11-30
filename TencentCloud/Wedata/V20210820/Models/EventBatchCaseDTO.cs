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

    public class EventBatchCaseDTO : AbstractModel
    {
        
        /// <summary>
        /// 事件实例id
        /// </summary>
        [JsonProperty("CaseId")]
        public string CaseId{ get; set; }

        /// <summary>
        /// 事件名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 事件触发起始时间
        /// </summary>
        [JsonProperty("StartDimension")]
        public string StartDimension{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreationTs")]
        public string CreationTs{ get; set; }

        /// <summary>
        /// 消费者id
        /// </summary>
        [JsonProperty("ConsumerId")]
        public string ConsumerId{ get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 事件触发结束时间
        /// </summary>
        [JsonProperty("EndDimension")]
        public string EndDimension{ get; set; }

        /// <summary>
        /// 事件周期
        /// </summary>
        [JsonProperty("EventSubType")]
        public string EventSubType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaseId", this.CaseId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "StartDimension", this.StartDimension);
            this.SetParamSimple(map, prefix + "CreationTs", this.CreationTs);
            this.SetParamSimple(map, prefix + "ConsumerId", this.ConsumerId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "EndDimension", this.EndDimension);
            this.SetParamSimple(map, prefix + "EventSubType", this.EventSubType);
        }
    }
}

