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

    public class DisplayHttp : AbstractModel
    {
        
        /// <summary>
        /// 主键ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 公共字段
        /// </summary>
        [JsonProperty("DisplayToolCommon")]
        public DisplayToolCommon DisplayToolCommon{ get; set; }

        /// <summary>
        /// Url
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 报文长度
        /// </summary>
        [JsonProperty("ContentLength")]
        public long? ContentLength{ get; set; }

        /// <summary>
        /// 报文内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 截图缩略图URL
        /// </summary>
        [JsonProperty("ScreenshotThumbUrl")]
        public string ScreenshotThumbUrl{ get; set; }

        /// <summary>
        /// 截图URL
        /// </summary>
        [JsonProperty("ScreenshotUrl")]
        public string ScreenshotUrl{ get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// Api地址
        /// </summary>
        [JsonProperty("Api")]
        public string Api{ get; set; }

        /// <summary>
        /// 解析的IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 证书信息
        /// </summary>
        [JsonProperty("Ssl")]
        public string Ssl{ get; set; }

        /// <summary>
        /// ssl证书过期时间
        /// </summary>
        [JsonProperty("SslExpiredTime")]
        public string SslExpiredTime{ get; set; }

        /// <summary>
        /// 资产是否发生变动
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsChange")]
        public bool? IsChange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "DisplayToolCommon.", this.DisplayToolCommon);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "ContentLength", this.ContentLength);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "ScreenshotThumbUrl", this.ScreenshotThumbUrl);
            this.SetParamSimple(map, prefix + "ScreenshotUrl", this.ScreenshotUrl);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Api", this.Api);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Ssl", this.Ssl);
            this.SetParamSimple(map, prefix + "SslExpiredTime", this.SslExpiredTime);
            this.SetParamSimple(map, prefix + "IsChange", this.IsChange);
        }
    }
}

