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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OwnNumberApplyDetailItem : AbstractModel
    {
        
        /// <summary>
        /// 号码类型：0-呼入|1-呼出|2-呼入呼出
        /// </summary>
        [JsonProperty("CallType")]
        public long? CallType{ get; set; }

        /// <summary>
        /// 线路号码
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 最大并发呼叫数
        /// </summary>
        [JsonProperty("MaxCallCount")]
        public long? MaxCallCount{ get; set; }

        /// <summary>
        /// 每秒最大并发数
        /// </summary>
        [JsonProperty("MaxCallPSec")]
        public long? MaxCallPSec{ get; set; }

        /// <summary>
        /// 呼出被叫格式，使用 {+E.164} 或 {E.164}, 
        /// </summary>
        [JsonProperty("OutboundCalleeFormat")]
        public string OutboundCalleeFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallType", this.CallType);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "MaxCallCount", this.MaxCallCount);
            this.SetParamSimple(map, prefix + "MaxCallPSec", this.MaxCallPSec);
            this.SetParamSimple(map, prefix + "OutboundCalleeFormat", this.OutboundCalleeFormat);
        }
    }
}

