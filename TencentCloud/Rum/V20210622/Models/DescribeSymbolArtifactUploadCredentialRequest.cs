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

    public class DescribeSymbolArtifactUploadCredentialRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>制品类型。取值：js_sourcemap、ios_dsym、macos_dsym、windows_pdb、android_mapping、android_native、system_symbol。</p>
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// <p>上传文件名。</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

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
        /// <p>保留字段，请勿传入。</p>
        /// </summary>
        [JsonProperty("Release")]
        public string Release{ get; set; }

        /// <summary>
        /// <p>保留字段，请勿传入。</p>
        /// </summary>
        [JsonProperty("Dist")]
        public string Dist{ get; set; }

        /// <summary>
        /// <p>保留字段，请勿传入。</p>
        /// </summary>
        [JsonProperty("MinifiedUrl")]
        public string MinifiedUrl{ get; set; }

        /// <summary>
        /// <p>保留字段，请勿传入。</p>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// <p>保留字段，请勿传入。</p>
        /// </summary>
        [JsonProperty("DebugId")]
        public string DebugId{ get; set; }

        /// <summary>
        /// <p>保留字段，请勿传入。</p>
        /// </summary>
        [JsonProperty("BuildId")]
        public string BuildId{ get; set; }

        /// <summary>
        /// <p>保留字段，请勿传入。</p>
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// <p>保留字段，请勿传入。</p>
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// <p>系统名称。</p>
        /// </summary>
        [JsonProperty("OS")]
        public string OS{ get; set; }

        /// <summary>
        /// <p>系统版本。</p>
        /// </summary>
        [JsonProperty("OSVersion")]
        public string OSVersion{ get; set; }

        /// <summary>
        /// <p>保留字段，请勿传入。</p>
        /// </summary>
        [JsonProperty("StorePath")]
        public string StorePath{ get; set; }

        /// <summary>
        /// <p>文件内容类型，如 application/json。</p>
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
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
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
        }
    }
}

