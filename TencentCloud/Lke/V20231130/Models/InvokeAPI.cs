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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InvokeAPI : AbstractModel
    {
        
        /// <summary>
        /// 请求方法，如GET/POST等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 请求地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// header参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeaderValues")]
        public StrValue[] HeaderValues{ get; set; }

        /// <summary>
        /// 入参Query
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueryValues")]
        public StrValue[] QueryValues{ get; set; }

        /// <summary>
        /// Post请求的原始数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestPostBody")]
        public string RequestPostBody{ get; set; }

        /// <summary>
        /// 返回的原始数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseBody")]
        public string ResponseBody{ get; set; }

        /// <summary>
        /// 出参
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseValues")]
        public ValueInfo[] ResponseValues{ get; set; }

        /// <summary>
        /// 异常信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailMessage")]
        public string FailMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamArrayObj(map, prefix + "HeaderValues.", this.HeaderValues);
            this.SetParamArrayObj(map, prefix + "QueryValues.", this.QueryValues);
            this.SetParamSimple(map, prefix + "RequestPostBody", this.RequestPostBody);
            this.SetParamSimple(map, prefix + "ResponseBody", this.ResponseBody);
            this.SetParamArrayObj(map, prefix + "ResponseValues.", this.ResponseValues);
            this.SetParamSimple(map, prefix + "FailMessage", this.FailMessage);
        }
    }
}

