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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TicketCheckTrendObj : AbstractModel
    {
        
        /// <summary>
        /// 时间参数
        /// </summary>
        [JsonProperty("Ftime")]
        public string Ftime{ get; set; }

        /// <summary>
        /// 票据校验量
        /// </summary>
        [JsonProperty("TicketCount")]
        public long? TicketCount{ get; set; }

        /// <summary>
        /// 票据通过量
        /// </summary>
        [JsonProperty("TicketThroughput")]
        public long? TicketThroughput{ get; set; }

        /// <summary>
        /// 票据拦截量
        /// </summary>
        [JsonProperty("TicketIntercept")]
        public long? TicketIntercept{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ftime", this.Ftime);
            this.SetParamSimple(map, prefix + "TicketCount", this.TicketCount);
            this.SetParamSimple(map, prefix + "TicketThroughput", this.TicketThroughput);
            this.SetParamSimple(map, prefix + "TicketIntercept", this.TicketIntercept);
        }
    }
}

