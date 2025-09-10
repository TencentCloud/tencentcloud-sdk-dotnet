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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WebSearchOptions : AbstractModel
    {
        
        /// <summary>
        /// 表示用户注入的知识信息
        /// </summary>
        [JsonProperty("Knowledge")]
        public Knowledge[] Knowledge{ get; set; }

        /// <summary>
        /// 用户位置详细信息
        /// </summary>
        [JsonProperty("UserLocation")]
        public UserLocation UserLocation{ get; set; }

        /// <summary>
        /// 打开开关，会返回搜索状态
        /// </summary>
        [JsonProperty("Processes")]
        public bool? Processes{ get; set; }

        /// <summary>
        /// 是否开启图文混排
        /// </summary>
        [JsonProperty("EnableImage")]
        public bool? EnableImage{ get; set; }

        /// <summary>
        /// 是否开启音乐
        /// </summary>
        [JsonProperty("EnableMusic")]
        public bool? EnableMusic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Knowledge.", this.Knowledge);
            this.SetParamObj(map, prefix + "UserLocation.", this.UserLocation);
            this.SetParamSimple(map, prefix + "Processes", this.Processes);
            this.SetParamSimple(map, prefix + "EnableImage", this.EnableImage);
            this.SetParamSimple(map, prefix + "EnableMusic", this.EnableMusic);
        }
    }
}

