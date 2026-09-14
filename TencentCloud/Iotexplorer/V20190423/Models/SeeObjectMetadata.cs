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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SeeObjectMetadata : AbstractModel
    {
        
        /// <summary>
        /// <p>对象 Key</p>
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// <p>对象的 COS URI</p>
        /// </summary>
        [JsonProperty("COSURI")]
        public string COSURI{ get; set; }

        /// <summary>
        /// <p>对象的 MIME 类型</p>
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// <p>对象大小，单位：字节</p>
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// <p>对象的 ETag</p>
        /// </summary>
        [JsonProperty("ETag")]
        public string ETag{ get; set; }

        /// <summary>
        /// <p>对象最后修改时间，秒级 UNIX 时间戳</p>
        /// </summary>
        [JsonProperty("LastModified")]
        public long? LastModified{ get; set; }

        /// <summary>
        /// <p>对象的自定义元数据列表</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public SeeObjectMetadataEntry[] Metadata{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "COSURI", this.COSURI);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "ETag", this.ETag);
            this.SetParamSimple(map, prefix + "LastModified", this.LastModified);
            this.SetParamArrayObj(map, prefix + "Metadata.", this.Metadata);
        }
    }
}

