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

namespace TencentCloud.Dataagent.V20250513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddChunkRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 文件ID
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 新增chunk的后面一个ChunkID。如果是空就是插到队尾。插入位置的下一个 chunkId。如果插到最前面，传入原切片的第一个。
        /// </summary>
        [JsonProperty("BeforeChunkId")]
        public string BeforeChunkId{ get; set; }

        /// <summary>
        /// 显式指定的位置,实际的位置。从 0 开始计算。0 代表插到最前面，chunk total 代表插到最后面。
        /// </summary>
        [JsonProperty("InsertPos")]
        public long? InsertPos{ get; set; }

        /// <summary>
        /// chunk内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 新 Chunk 插入到目标 Chunk ​之后的位置。插入位置的上一个 chunkId
        /// </summary>
        [JsonProperty("AfterChunkId")]
        public string AfterChunkId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "BeforeChunkId", this.BeforeChunkId);
            this.SetParamSimple(map, prefix + "InsertPos", this.InsertPos);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "AfterChunkId", this.AfterChunkId);
        }
    }
}

