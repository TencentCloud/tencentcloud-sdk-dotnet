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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RiskCallRecord : AbstractModel
    {
        
        /// <summary>
        /// 接口名称
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// 接口中文描述
        /// </summary>
        [JsonProperty("EventDescCN")]
        public string EventDescCN{ get; set; }

        /// <summary>
        /// 接口英文描述
        /// </summary>
        [JsonProperty("EventDescEN")]
        public string EventDescEN{ get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 产品中文名称
        /// </summary>
        [JsonProperty("ProductNameCN")]
        public string ProductNameCN{ get; set; }

        /// <summary>
        /// 调用次数
        /// </summary>
        [JsonProperty("CallCount")]
        public long? CallCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "EventDescCN", this.EventDescCN);
            this.SetParamSimple(map, prefix + "EventDescEN", this.EventDescEN);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ProductNameCN", this.ProductNameCN);
            this.SetParamSimple(map, prefix + "CallCount", this.CallCount);
        }
    }
}

