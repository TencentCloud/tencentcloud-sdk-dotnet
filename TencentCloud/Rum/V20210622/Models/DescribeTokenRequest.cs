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

    public class DescribeTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>筛选条件</p>
        /// </summary>
        [JsonProperty("FormListString")]
        public string FormListString{ get; set; }

        /// <summary>
        /// <p>仅对比模式下填写，筛选条件A</p>
        /// </summary>
        [JsonProperty("FormListAString")]
        public string FormListAString{ get; set; }

        /// <summary>
        /// <p>仅对比模式下填写，筛选条件B</p>
        /// </summary>
        [JsonProperty("FormListBString")]
        public string FormListBString{ get; set; }

        /// <summary>
        /// <p>请求头</p>
        /// </summary>
        [JsonProperty("RequestHeader")]
        public string RequestHeader{ get; set; }

        /// <summary>
        /// <p>拓展字段</p>
        /// </summary>
        [JsonProperty("ExtraData")]
        public string ExtraData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FormListString", this.FormListString);
            this.SetParamSimple(map, prefix + "FormListAString", this.FormListAString);
            this.SetParamSimple(map, prefix + "FormListBString", this.FormListBString);
            this.SetParamSimple(map, prefix + "RequestHeader", this.RequestHeader);
            this.SetParamSimple(map, prefix + "ExtraData", this.ExtraData);
        }
    }
}

