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

namespace TencentCloud.Eb.V20210416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateTargetRequest : AbstractModel
    {
        
        /// <summary>
        /// 事件集ID
        /// </summary>
        [JsonProperty("EventBusId")]
        public string EventBusId{ get; set; }

        /// <summary>
        /// 事件规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 事件目标ID
        /// </summary>
        [JsonProperty("TargetId")]
        public string TargetId{ get; set; }

        /// <summary>
        /// 开启批量投递使能
        /// </summary>
        [JsonProperty("EnableBatchDelivery")]
        public bool? EnableBatchDelivery{ get; set; }

        /// <summary>
        /// 批量投递最长等待时间
        /// </summary>
        [JsonProperty("BatchTimeout")]
        public long? BatchTimeout{ get; set; }

        /// <summary>
        /// 批量投递最大事件条数
        /// </summary>
        [JsonProperty("BatchEventCount")]
        public long? BatchEventCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventBusId", this.EventBusId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "TargetId", this.TargetId);
            this.SetParamSimple(map, prefix + "EnableBatchDelivery", this.EnableBatchDelivery);
            this.SetParamSimple(map, prefix + "BatchTimeout", this.BatchTimeout);
            this.SetParamSimple(map, prefix + "BatchEventCount", this.BatchEventCount);
        }
    }
}

