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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFOOMMallocProblemDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>产品Id</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// <p>消息唯一标识</p>
        /// </summary>
        [JsonProperty("ClientIdentify")]
        public string ClientIdentify{ get; set; }

        /// <summary>
        /// <p>特征</p>
        /// </summary>
        [JsonProperty("Feature")]
        public string Feature{ get; set; }

        /// <summary>
        /// <p>事件开始时间</p>
        /// </summary>
        [JsonProperty("StartEventTime")]
        public long? StartEventTime{ get; set; }

        /// <summary>
        /// <p>事件结束时间</p>
        /// </summary>
        [JsonProperty("EndEventTime")]
        public long? EndEventTime{ get; set; }

        /// <summary>
        /// <p>拓展数据</p>
        /// </summary>
        [JsonProperty("ExtraData")]
        public string ExtraData{ get; set; }

        /// <summary>
        /// <p>请求头</p>
        /// </summary>
        [JsonProperty("RequestHeader")]
        public string RequestHeader{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ClientIdentify", this.ClientIdentify);
            this.SetParamSimple(map, prefix + "Feature", this.Feature);
            this.SetParamSimple(map, prefix + "StartEventTime", this.StartEventTime);
            this.SetParamSimple(map, prefix + "EndEventTime", this.EndEventTime);
            this.SetParamSimple(map, prefix + "ExtraData", this.ExtraData);
            this.SetParamSimple(map, prefix + "RequestHeader", this.RequestHeader);
        }
    }
}

