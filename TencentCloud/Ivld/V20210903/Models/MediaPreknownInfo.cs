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

    public class MediaPreknownInfo : AbstractModel
    {
        
        /// <summary>
        /// 媒资文件类型，参见MediaPreknownInfo结构体定义
        /// </summary>
        [JsonProperty("MediaType")]
        public long? MediaType{ get; set; }

        /// <summary>
        /// 媒资素材一级类型，参见MediaPreknownInfo结构体定义
        /// </summary>
        [JsonProperty("MediaLabel")]
        public long? MediaLabel{ get; set; }

        /// <summary>
        /// 媒资素材二级类型，参见MediaPreknownInfo结构体定义
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MediaSecondLabel")]
        public long? MediaSecondLabel{ get; set; }

        /// <summary>
        /// 媒资音频类型，参见MediaPreknownInfo结构体定义
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MediaLang")]
        public long? MediaLang{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MediaType", this.MediaType);
            this.SetParamSimple(map, prefix + "MediaLabel", this.MediaLabel);
            this.SetParamSimple(map, prefix + "MediaSecondLabel", this.MediaSecondLabel);
            this.SetParamSimple(map, prefix + "MediaLang", this.MediaLang);
        }
    }
}

