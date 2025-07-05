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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComposeMediaTrack : AbstractModel
    {
        
        /// <summary>
        /// 轨道类型，取值有：<ul><li>Video ：视频轨道。视频轨道可由以下元素组成：</li><ul><li>Video 元素</li><li>Image 元素</li><li>Transition 元素</li><li>Empty 元素</li></ul><li>Audio ：音频轨道。音频轨道可由以下元素组成：</li><ul><li>Audio 元素</li><li>Transition 元素</li><li>Empty 元素</li></ul><li>Title：文字轨道。文字轨道可由以下元素组成：</li><ul><li>Subtitle 元素</li></ul></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 轨道上的元素列表。
        /// </summary>
        [JsonProperty("Items")]
        public ComposeMediaItem[] Items{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
        }
    }
}

