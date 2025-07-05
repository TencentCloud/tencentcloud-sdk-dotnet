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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaFilter : AbstractModel
    {
        
        /// <summary>
        /// 媒资名称过滤条件
        /// </summary>
        [JsonProperty("MediaNameSet")]
        public string[] MediaNameSet{ get; set; }

        /// <summary>
        /// 媒资状态数组，媒资状态可选值参见MediaInfo
        /// </summary>
        [JsonProperty("StatusSet")]
        public long?[] StatusSet{ get; set; }

        /// <summary>
        /// 媒资ID数组
        /// </summary>
        [JsonProperty("MediaIdSet")]
        public string[] MediaIdSet{ get; set; }

        /// <summary>
        /// 媒资自定义标签数组
        /// </summary>
        [JsonProperty("LabelSet")]
        public string[] LabelSet{ get; set; }

        /// <summary>
        /// 媒资文件类型，定义参见[MediaPreknownInfo.MediaType](https://cloud.tencent.com/document/product/1509/65063#MediaPreknownInfo)
        /// </summary>
        [JsonProperty("MediaType")]
        public long? MediaType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MediaNameSet.", this.MediaNameSet);
            this.SetParamArraySimple(map, prefix + "StatusSet.", this.StatusSet);
            this.SetParamArraySimple(map, prefix + "MediaIdSet.", this.MediaIdSet);
            this.SetParamArraySimple(map, prefix + "LabelSet.", this.LabelSet);
            this.SetParamSimple(map, prefix + "MediaType", this.MediaType);
        }
    }
}

