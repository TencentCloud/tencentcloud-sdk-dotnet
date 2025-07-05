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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExternalMediaInfo : AbstractModel
    {
        
        /// <summary>
        /// 目前仅支持绑定 COS 桶的媒体，请填写存储对象 Key 值，例如：`example-folder/example.mp4`。
        /// </summary>
        [JsonProperty("MediaKey")]
        public string MediaKey{ get; set; }

        /// <summary>
        /// 该字段废弃，请勿使用。
        /// </summary>
        [JsonProperty("Definition")]
        [System.Obsolete]
        public long? Definition{ get; set; }

        /// <summary>
        /// 媒资挂载的存储 Id。
        /// </summary>
        [JsonProperty("StorageId")]
        public string StorageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MediaKey", this.MediaKey);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "StorageId", this.StorageId);
        }
    }
}

