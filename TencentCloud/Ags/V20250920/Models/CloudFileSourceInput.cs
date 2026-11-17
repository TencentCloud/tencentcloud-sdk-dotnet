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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudFileSourceInput : AbstractModel
    {
        
        /// <summary>
        /// <p>通用文件来源类型，区分大小写。</p><p>枚举值：</p><ul><li>FILE： 创建 Plugin 文件版本，必须填写 SizeBytes，SHA256 可选；随后通过预签名 PUT 链接上传原始文件。</li><li>VERSION： 仅 UpdateRegistryRecord 支持，复用同一 Skill 或 Plugin Record 的 READY 文件版本，仅填写 SourceVersionId。</li></ul><p>Registry 不做 Plugin 文件内容格式或语义校验，由运行端解析加载。VERSION 不继承来源版本的 Metadata 和 SupportedHarnessVersions。</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>待上传 Plugin 文件的原始字节数。FILE 时必填，VERSION 时禁止填写。</p><p>取值范围：[1, 54525952]</p><p>单位：字节</p><p>上限 52 MiB，服务端校验实际上传文件的字节数；不推断文件格式。</p>
        /// </summary>
        [JsonProperty("SizeBytes")]
        public long? SizeBytes{ get; set; }

        /// <summary>
        /// <p>期望的文件 SHA-256 摘要。FILE 时可选，VERSION 时禁止填写。</p><p>参数格式：64 位小写十六进制字符串。</p><p>提供时服务端计算实际文件摘要并比对；省略时仍计算摘要并在 READY 版本的 ContentSHA256 中返回。</p>
        /// </summary>
        [JsonProperty("SHA256")]
        public string SHA256{ get; set; }

        /// <summary>
        /// <p>用于复用文件内容的来源 Version ID。</p><p>参数格式：rv- 前缀的 Version ID。</p><p>入参限制：VERSION 时必填，FILE 时禁止填写。只能在 UpdateRegistryRecord 中引用同一 Record 下未删除、内容 READY 且存在可用制品的 Skill 或 Plugin 文件版本。</p><p>只复用文件，不继承来源版本的 Metadata 和 SupportedHarnessVersions；不能跨 Record 或跨 Registry 复用。</p>
        /// </summary>
        [JsonProperty("SourceVersionId")]
        public string SourceVersionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SizeBytes", this.SizeBytes);
            this.SetParamSimple(map, prefix + "SHA256", this.SHA256);
            this.SetParamSimple(map, prefix + "SourceVersionId", this.SourceVersionId);
        }
    }
}

