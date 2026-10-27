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

    public class IntelligenceResult : AbstractModel
    {
        
        /// <summary>
        /// <p>客户ID</p>
        /// </summary>
        [JsonProperty("CustomerId")]
        public long? CustomerId{ get; set; }

        /// <summary>
        /// <p>客户名称</p>
        /// </summary>
        [JsonProperty("CustomerName")]
        public string CustomerName{ get; set; }

        /// <summary>
        /// <p>标题</p>
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// <p>指纹</p>
        /// </summary>
        [JsonProperty("Banner")]
        public string Banner{ get; set; }

        /// <summary>
        /// <p>截图预览</p>
        /// </summary>
        [JsonProperty("ScreenshotUrl")]
        public string ScreenshotUrl{ get; set; }

        /// <summary>
        /// <p>是否受影响</p>
        /// </summary>
        [JsonProperty("IsAffected")]
        public bool? IsAffected{ get; set; }

        /// <summary>
        /// <p>网址</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerId", this.CustomerId);
            this.SetParamSimple(map, prefix + "CustomerName", this.CustomerName);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Banner", this.Banner);
            this.SetParamSimple(map, prefix + "ScreenshotUrl", this.ScreenshotUrl);
            this.SetParamSimple(map, prefix + "IsAffected", this.IsAffected);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

