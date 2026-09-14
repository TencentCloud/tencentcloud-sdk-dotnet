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

    public class DocMetadata : AbstractModel
    {
        
        /// <summary>
        /// <p>文档字符数</p>
        /// </summary>
        [JsonProperty("DocCharCount")]
        public string DocCharCount{ get; set; }

        /// <summary>
        /// <p>文件名</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>文件大小（字节）</p>
        /// </summary>
        [JsonProperty("FileSize")]
        public string FileSize{ get; set; }

        /// <summary>
        /// <p>文件类型/扩展名</p>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// <p>元数据引用字段名列表（用于显示文档哪些分类和属性被设置为元数据）</p>
        /// </summary>
        [JsonProperty("RefFieldNameList")]
        public string[] RefFieldNameList{ get; set; }

        /// <summary>
        /// <p>来源描述</p>
        /// </summary>
        [JsonProperty("SourceDesc")]
        public string SourceDesc{ get; set; }

        /// <summary>
        /// <p>文档来源类型：1=本地上传，2=网页链接，3=COS 对接，4=外部导入<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>DOC_SOURCE_TYPE_UNKNOWN</td><td>0</td><td></td></tr><tr><td>DOC_SOURCE_TYPE_LOCAL</td><td>1</td><td>本地上传</td></tr><tr><td>DOC_SOURCE_TYPE_URL</td><td>2</td><td>网页链接</td></tr><tr><td>DOC_SOURCE_TYPE_COS</td><td>3</td><td>COS 对接</td></tr><tr><td>DOC_SOURCE_TYPE_IMPORT</td><td>4</td><td>外部导入</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("SourceType")]
        public long? SourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DocCharCount", this.DocCharCount);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamArraySimple(map, prefix + "RefFieldNameList.", this.RefFieldNameList);
            this.SetParamSimple(map, prefix + "SourceDesc", this.SourceDesc);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
        }
    }
}

