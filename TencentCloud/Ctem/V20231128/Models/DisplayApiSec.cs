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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisplayApiSec : AbstractModel
    {
        
        /// <summary>
        /// <p>主键ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>公共字段</p>
        /// </summary>
        [JsonProperty("DisplayToolCommon")]
        public DisplayToolCommon DisplayToolCommon{ get; set; }

        /// <summary>
        /// <p>Url</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>Host地址</p>
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// <p>Path路径</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>方法：POST、GET、DELETE等</p>
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// <p>修复状态：unrepaired:未修复，repaired:已修复, ignore:已忽略,checking:复测中</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>状态码</p>
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// <p>请求体</p>
        /// </summary>
        [JsonProperty("Request")]
        public string Request{ get; set; }

        /// <summary>
        /// <p>响应体</p>
        /// </summary>
        [JsonProperty("Response")]
        public string Response{ get; set; }

        /// <summary>
        /// <p>是否风险API</p>
        /// </summary>
        [JsonProperty("IsRiskAPI")]
        public bool? IsRiskAPI{ get; set; }

        /// <summary>
        /// <p>聚合视角下该组真实子项总数；非聚合视角为 0</p>
        /// </summary>
        [JsonProperty("AggregationCount")]
        public long? AggregationCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "DisplayToolCommon.", this.DisplayToolCommon);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Request", this.Request);
            this.SetParamSimple(map, prefix + "Response", this.Response);
            this.SetParamSimple(map, prefix + "IsRiskAPI", this.IsRiskAPI);
            this.SetParamSimple(map, prefix + "AggregationCount", this.AggregationCount);
        }
    }
}

