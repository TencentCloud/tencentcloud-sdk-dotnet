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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Filter : AbstractModel
    {
        
        /// <summary>
        /// 等于：0，不等于：1
        /// </summary>
        [JsonProperty("Operator")]
        public long? Operator{ get; set; }

        /// <summary>
        /// 标签名，可选值包括：
        /// 1. method，请求方法名；
        /// 2. proto：协议名；
        /// 3. service：服务名；
        /// 4. status：响应状态码；
        /// 5. result：响应详情；
        /// 6. check：检查名。
        /// </summary>
        [JsonProperty("LabelName")]
        public string LabelName{ get; set; }

        /// <summary>
        /// 标签值：
        /// 1. method：请求方法名，以 http 协议为例，method 为 GET、POST、PUT 等；
        /// 2. proto：协议名，以 http 协议为例，proto 为 HTTP/1.1、HTTP/2 等；
        /// 3. service：服务名，以 http 协议为例，service 为请求 url，如 http://httpbin.org/get 等；
        /// 4. status：响应状态码，以 http 协议为例，状态码包括 200、404、500 等；
        /// 5. result：响应详情，通过 result 判断请求成功或失败；请求正常，result 标签值为 ok；请求失败，result 标签携带错误码和描述；
        /// 6. check：检查名，标签值为用户设置的检查点名称。
        /// </summary>
        [JsonProperty("LabelValue")]
        public string LabelValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "LabelName", this.LabelName);
            this.SetParamSimple(map, prefix + "LabelValue", this.LabelValue);
        }
    }
}

