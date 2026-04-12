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

    public class DescribeApplicationExitReportDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品Id
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 提供给前端使用，当填写本字段时，会覆盖 formlist 的值
        /// </summary>
        [JsonProperty("ParamToken")]
        public string ParamToken{ get; set; }

        /// <summary>
        /// 问题Id
        /// </summary>
        [JsonProperty("ClientIdentify")]
        public string ClientIdentify{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartEventTime")]
        public long? StartEventTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndEventTime")]
        public long? EndEventTime{ get; set; }

        /// <summary>
        /// 拓展数据
        /// </summary>
        [JsonProperty("ExtraData")]
        public string ExtraData{ get; set; }

        /// <summary>
        /// 请求头
        /// </summary>
        [JsonProperty("RequestHeader")]
        public string RequestHeader{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ParamToken", this.ParamToken);
            this.SetParamSimple(map, prefix + "ClientIdentify", this.ClientIdentify);
            this.SetParamSimple(map, prefix + "StartEventTime", this.StartEventTime);
            this.SetParamSimple(map, prefix + "EndEventTime", this.EndEventTime);
            this.SetParamSimple(map, prefix + "ExtraData", this.ExtraData);
            this.SetParamSimple(map, prefix + "RequestHeader", this.RequestHeader);
        }
    }
}

