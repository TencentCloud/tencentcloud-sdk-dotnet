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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImportQAsRequest : AbstractModel
    {
        
        /// <summary>
        /// 知识库ID
        /// </summary>
        [JsonProperty("KnowledgeBaseId")]
        public string KnowledgeBaseId{ get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 文件的 Url 地址。文件存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议文件存储于腾讯云。 非腾讯云存储的 Url 速度和稳定性可能受一定影响。
        /// 导入模板：https://cdn.xiaowei.qq.com/lke/assets//static/批量导入问答模板v6.xlsx
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// 文件类型，仅支持XLSX格式，请使用模板
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KnowledgeBaseId", this.KnowledgeBaseId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
        }
    }
}

