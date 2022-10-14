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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDocumentRequest : AbstractModel
    {
        
        /// <summary>
        /// 低代码互动课堂的SdkAppId。
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 文档地址。
        /// </summary>
        [JsonProperty("DocumentUrl")]
        public string DocumentUrl{ get; set; }

        /// <summary>
        /// 文档名称。
        /// </summary>
        [JsonProperty("DocumentName")]
        public string DocumentName{ get; set; }

        /// <summary>
        /// 文档所有者的Id
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// 转码类型，可以有如下取值：
        /// 0 无需转码（默认）
        /// 1 需要转码的文档，ppt，pptx，pdf，doc，docx
        /// 2 需要转码的视频，mp4，3pg，mpeg，avi，flv，wmv，rm，h264等
        /// 2 需要转码的音频，mp3，wav，wma，aac，flac，opus
        /// </summary>
        [JsonProperty("TranscodeType")]
        public ulong? TranscodeType{ get; set; }

        /// <summary>
        /// 权限，可以有如下取值：
        /// 0 私有文档（默认）
        /// 1 公共文档
        /// </summary>
        [JsonProperty("Permission")]
        public ulong? Permission{ get; set; }

        /// <summary>
        /// 文档后缀名。
        /// </summary>
        [JsonProperty("DocumentType")]
        public string DocumentType{ get; set; }

        /// <summary>
        /// 文档大小，单位 字节
        /// </summary>
        [JsonProperty("DocumentSize")]
        public ulong? DocumentSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "DocumentUrl", this.DocumentUrl);
            this.SetParamSimple(map, prefix + "DocumentName", this.DocumentName);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "TranscodeType", this.TranscodeType);
            this.SetParamSimple(map, prefix + "Permission", this.Permission);
            this.SetParamSimple(map, prefix + "DocumentType", this.DocumentType);
            this.SetParamSimple(map, prefix + "DocumentSize", this.DocumentSize);
        }
    }
}

