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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLiveAvatarScriptRequest : AbstractModel
    {
        
        /// <summary>
        /// 数字人直播间话术 ID。
        /// </summary>
        [JsonProperty("ScriptId")]
        public string ScriptId{ get; set; }

        /// <summary>
        /// 话术标题，限制500字节。
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 话术内容，限制1000字节。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 修改已有话术的位置。
        /// 比如已有话术三条，位置分别为100，200，300。
        /// 可将第三条话术改到第一条和第二条中间，则可指定第三条话术的位置为 150。
        /// 每次指定尽量取两条话术的中间位置，如50,150等，为后面顺序调整预留位置。
        /// </summary>
        [JsonProperty("SpecifyPosition")]
        public long? SpecifyPosition{ get; set; }

        /// <summary>
        /// 操作者。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScriptId", this.ScriptId);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "SpecifyPosition", this.SpecifyPosition);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

