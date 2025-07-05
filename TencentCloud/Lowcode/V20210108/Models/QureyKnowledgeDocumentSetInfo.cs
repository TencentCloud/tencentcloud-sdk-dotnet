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

namespace TencentCloud.Lowcode.V20210108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QureyKnowledgeDocumentSetInfo : AbstractModel
    {
        
        /// <summary>
        /// 文件的字符数。
        /// </summary>
        [JsonProperty("TextLength")]
        public ulong? TextLength{ get; set; }

        /// <summary>
        /// 文件的字节数。
        /// </summary>
        [JsonProperty("ByteLength")]
        public ulong? ByteLength{ get; set; }

        /// <summary>
        /// 文件被预处理、Embedding 向量化的进度。
        /// </summary>
        [JsonProperty("IndexedProgress")]
        public ulong? IndexedProgress{ get; set; }

        /// <summary>
        /// 文件预处理、Embedding 向量化的状态。
        /// New：等待解析。
        /// Loading：文件解析中。
        /// Failure：文件解析、写入出错。
        /// Ready：文件解析、写入完成。
        /// </summary>
        [JsonProperty("IndexedStatus")]
        public string IndexedStatus{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("IndexedErrorMsg")]
        public string IndexedErrorMsg{ get; set; }

        /// <summary>
        /// 文件创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 文件最后更新时间。
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }

        /// <summary>
        /// 文件关键字。
        /// </summary>
        [JsonProperty("Keywords")]
        public string Keywords{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TextLength", this.TextLength);
            this.SetParamSimple(map, prefix + "ByteLength", this.ByteLength);
            this.SetParamSimple(map, prefix + "IndexedProgress", this.IndexedProgress);
            this.SetParamSimple(map, prefix + "IndexedStatus", this.IndexedStatus);
            this.SetParamSimple(map, prefix + "IndexedErrorMsg", this.IndexedErrorMsg);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamSimple(map, prefix + "Keywords", this.Keywords);
        }
    }
}

