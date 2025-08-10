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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadLogRequest : AbstractModel, IOctetRequest
    {
        
        /// <summary>
        /// 日志主题id
        /// - 通过[获取日志主题列表](https://cloud.tencent.com/document/product/614/56454)获取日志主题Id。
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 该参数已废弃，请勿使用
        /// </summary>
        [JsonProperty("HashKey")]
        [System.Obsolete]
        public string HashKey{ get; set; }

        /// <summary>
        /// 压缩方法，目前支持
        /// - lz4
        /// - zstd
        /// </summary>
        [JsonProperty("CompressType")]
        public string CompressType{ get; set; }

        public byte[] OctetBody { get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "HashKey", this.HashKey);
            this.SetParamSimple(map, prefix + "CompressType", this.CompressType);
        }
    }
}

