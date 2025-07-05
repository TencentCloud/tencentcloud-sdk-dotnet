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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScriptInfo : AbstractModel
    {
        
        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// base64编码后的文件内容
        /// </summary>
        [JsonProperty("EncodedContent")]
        public string EncodedContent{ get; set; }

        /// <summary>
        /// base64编码后的har结构体
        /// </summary>
        [JsonProperty("EncodedHttpArchive")]
        public string EncodedHttpArchive{ get; set; }

        /// <summary>
        /// 脚本权重，范围 1-100
        /// </summary>
        [JsonProperty("LoadWeight")]
        public long? LoadWeight{ get; set; }

        /// <summary>
        /// 文件 ID
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 文件是否已上传，如果已上传，则可以不必填写 EncodedContent,EncodedHar 等内容。
        /// 主要用于较大长度脚本上传。
        /// </summary>
        [JsonProperty("Uploaded")]
        public bool? Uploaded{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "EncodedContent", this.EncodedContent);
            this.SetParamSimple(map, prefix + "EncodedHttpArchive", this.EncodedHttpArchive);
            this.SetParamSimple(map, prefix + "LoadWeight", this.LoadWeight);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Uploaded", this.Uploaded);
        }
    }
}

