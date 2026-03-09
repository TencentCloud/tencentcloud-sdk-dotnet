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

    public class ModifyNetworkApplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网络应用id</p>
        /// </summary>
        [JsonProperty("NetworkAppId")]
        public string NetworkAppId{ get; set; }

        /// <summary>
        /// <p>网络应用名称：长度不超过64字符，名称不能重复。</p><ul><li>只能包含以下字符：<ul><li>英文字母（大小写）</li><li>数字</li><li>下划线</li><li>连字符（减号）</li><li>汉字</li></ul></li><li>至少包含一个字符</li><li>不能包含空格</li><li>不能包含其他特殊字符（如 @、#、$、% 等）</li></ul>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkAppId", this.NetworkAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

