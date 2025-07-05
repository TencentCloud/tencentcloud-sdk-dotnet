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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIvrAudioListRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID（必填），可以查看 https://console.cloud.tencent.com/ccc
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 分页尺寸，上限 50
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 分页页码，从 0 开始
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 文件别名
        /// </summary>
        [JsonProperty("CustomFileName")]
        public string[] CustomFileName{ get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("AudioFileName")]
        public string[] AudioFileName{ get; set; }

        /// <summary>
        /// 文件ID
        /// </summary>
        [JsonProperty("FileId")]
        public ulong?[] FileId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamArraySimple(map, prefix + "CustomFileName.", this.CustomFileName);
            this.SetParamArraySimple(map, prefix + "AudioFileName.", this.AudioFileName);
            this.SetParamArraySimple(map, prefix + "FileId.", this.FileId);
        }
    }
}

