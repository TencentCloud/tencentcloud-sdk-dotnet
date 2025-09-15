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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaInputInfo : AbstractModel
    {
        
        /// <summary>
        /// 输入来源对象的类型，支持：
        /// <li> COS：COS源</li>
        /// <li> URL：URL源</li>
        /// <li> AWS-S3：AWS 源，目前只支持转码任务 </li>
        /// <li> VOD：点播专业版 </li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 当 Type 为 COS 时有效，则该项为必填，表示媒体处理 COS 对象信息。
        /// </summary>
        [JsonProperty("CosInputInfo")]
        public CosInputInfo CosInputInfo{ get; set; }

        /// <summary>
        /// 当 Type 为 URL 时有效，则该项为必填，表示媒体处理 URL 对象信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UrlInputInfo")]
        public UrlInputInfo UrlInputInfo{ get; set; }

        /// <summary>
        /// 当 Type 为 AWS-S3 时有效，则该项为必填，表示媒体处理 AWS S3 对象信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("S3InputInfo")]
        public S3InputInfo S3InputInfo{ get; set; }

        /// <summary>
        /// 当 Type 为 VOD 时有效，则该项为必填，表示媒体处理 点播专业版 对象信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VODInputInfo")]
        public VODInputInfo VODInputInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "CosInputInfo.", this.CosInputInfo);
            this.SetParamObj(map, prefix + "UrlInputInfo.", this.UrlInputInfo);
            this.SetParamObj(map, prefix + "S3InputInfo.", this.S3InputInfo);
            this.SetParamObj(map, prefix + "VODInputInfo.", this.VODInputInfo);
        }
    }
}

