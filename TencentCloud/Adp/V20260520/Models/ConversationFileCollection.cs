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

    public class ConversationFileCollection : AbstractModel
    {
        
        /// <summary>
        /// <p>最大文件数量</p>
        /// </summary>
        [JsonProperty("MaxFileCount")]
        public long? MaxFileCount{ get; set; }

        /// <summary>
        /// <p>支持的文件类型列表</p>
        /// </summary>
        [JsonProperty("SupportedFileTypeList")]
        public string[] SupportedFileTypeList{ get; set; }

        /// <summary>
        /// <p>支持的文件类型列表</p>
        /// </summary>
        [JsonProperty("SupportedFileTypes")]
        public string[] SupportedFileTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxFileCount", this.MaxFileCount);
            this.SetParamArraySimple(map, prefix + "SupportedFileTypeList.", this.SupportedFileTypeList);
            this.SetParamArraySimple(map, prefix + "SupportedFileTypes.", this.SupportedFileTypes);
        }
    }
}

