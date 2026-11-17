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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DocumentParseUsageDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>应用 ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>消耗资源数（PU）</p>
        /// </summary>
        [JsonProperty("ConsumptionPu")]
        public float? ConsumptionPu{ get; set; }

        /// <summary>
        /// <p>文档 ID</p>
        /// </summary>
        [JsonProperty("DocId")]
        public string DocId{ get; set; }

        /// <summary>
        /// <p>文档解析方式：离线文档解析、实时文档解析。上报值 OfflineUpload 对应离线文档解析；RealtimeUpload、RealTimeDocParse 对应实时文档解析</p>
        /// </summary>
        [JsonProperty("DocUsageMethod")]
        public string DocUsageMethod{ get; set; }

        /// <summary>
        /// <p>知识库 ID</p>
        /// </summary>
        [JsonProperty("KbId")]
        public string KbId{ get; set; }

        /// <summary>
        /// <p>解析页数</p>
        /// </summary>
        [JsonProperty("ParsedPageCount")]
        public string ParsedPageCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ConsumptionPu", this.ConsumptionPu);
            this.SetParamSimple(map, prefix + "DocId", this.DocId);
            this.SetParamSimple(map, prefix + "DocUsageMethod", this.DocUsageMethod);
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamSimple(map, prefix + "ParsedPageCount", this.ParsedPageCount);
        }
    }
}

