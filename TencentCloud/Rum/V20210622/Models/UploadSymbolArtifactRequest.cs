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

    public class UploadSymbolArtifactRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>制品类型。取值：js_sourcemap、ios_dsym、macos_dsym、windows_pdb、android_mapping、android_native、system_symbol。</p>
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// <p>对象大小（字节）。</p>
        /// </summary>
        [JsonProperty("FileSize")]
        public long? FileSize{ get; set; }

        /// <summary>
        /// <p>对象内容的 SHA256 十六进制摘要，长度固定为 64 个字符。</p>
        /// </summary>
        [JsonProperty("Sha256")]
        public string Sha256{ get; set; }

        /// <summary>
        /// <p>已上传对象的腾讯云 COS URL。与 FileUrl 二选一至少传一个；优先使用 COSUrl。必须属于当前配置的 Bucket 和 Region。</p>
        /// </summary>
        [JsonProperty("COSUrl")]
        public string COSUrl{ get; set; }

        /// <summary>
        /// <p>应用 ID。应用级制品必填；system_symbol 不传。</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>兼容别名，未传 AppId 时使用。</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>JS 应用版本。未传 AppVersion 时使用。</p>
        /// </summary>
        [JsonProperty("Release")]
        public string Release{ get; set; }

        /// <summary>
        /// <p>兼容字段，不参与制品匹配。</p>
        /// </summary>
        [JsonProperty("Dist")]
        public string Dist{ get; set; }

        /// <summary>
        /// <p>压缩文件 URL。Kind=js_sourcemap 且 FileType 非 source_bundle 时必填。</p>
        /// </summary>
        [JsonProperty("MinifiedUrl")]
        public string MinifiedUrl{ get; set; }

        /// <summary>
        /// <p>JS 制品文件类型。可选值说明：sourcemap、minified、source_bundle；为空时默认 sourcemap。</p>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// <p>调试 ID。除 js_sourcemap 外均必填。</p>
        /// </summary>
        [JsonProperty("DebugId")]
        public string DebugId{ get; set; }

        /// <summary>
        /// <p>构建 ID。ios_dsym、android_mapping、android_native 必填。</p>
        /// </summary>
        [JsonProperty("BuildId")]
        public string BuildId{ get; set; }

        /// <summary>
        /// <p>应用版本。js_sourcemap 必填，未传时使用 Release。</p>
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// <p>兼容字段，请勿传入。</p>
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// <p>系统名称。system_symbol 可填写。</p>
        /// </summary>
        [JsonProperty("OS")]
        public string OS{ get; set; }

        /// <summary>
        /// <p>系统版本。system_symbol 可填写。</p>
        /// </summary>
        [JsonProperty("OSVersion")]
        public string OSVersion{ get; set; }

        /// <summary>
        /// <p>兼容字段，请勿传入。</p>
        /// </summary>
        [JsonProperty("StorePath")]
        public string StorePath{ get; set; }

        /// <summary>
        /// <p>文件名。原生和系统符号必填；ios_dsym 使用模块名，android_native 使用 abi/文件名。</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>文件内容类型，如 application/json。</p>
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// <p>COSUrl 的兼容别名；当未传 COSUrl 时使用。与 COSUrl 二选一至少传一个。</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "Sha256", this.Sha256);
            this.SetParamSimple(map, prefix + "COSUrl", this.COSUrl);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Release", this.Release);
            this.SetParamSimple(map, prefix + "Dist", this.Dist);
            this.SetParamSimple(map, prefix + "MinifiedUrl", this.MinifiedUrl);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "DebugId", this.DebugId);
            this.SetParamSimple(map, prefix + "BuildId", this.BuildId);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "OS", this.OS);
            this.SetParamSimple(map, prefix + "OSVersion", this.OSVersion);
            this.SetParamSimple(map, prefix + "StorePath", this.StorePath);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
        }
    }
}

