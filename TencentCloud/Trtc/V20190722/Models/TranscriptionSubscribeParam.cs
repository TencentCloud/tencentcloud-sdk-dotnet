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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TranscriptionSubscribeParam : AbstractModel
    {
        
        /// <summary>
        /// <p>转录用户白名单，为空或不填表示转录所有主播音频，填具体值表示转录指定主播音频。 使用黑白名单时，同一个用户同时在黑白名单时，以黑名单为主。</p>
        /// </summary>
        [JsonProperty("SubscribeList")]
        public TranscriptionUserInfoParams[] SubscribeList{ get; set; }

        /// <summary>
        /// <p>转录用户黑名单，为空或不填表示无黑名单，填具体值表示不转录指定主播音频。 同一个用户同时在黑白名单时，以黑名单为主。</p>
        /// </summary>
        [JsonProperty("UnSubscribeList")]
        public TranscriptionUserInfoParams[] UnSubscribeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "SubscribeList.", this.SubscribeList);
            this.SetParamArrayObj(map, prefix + "UnSubscribeList.", this.UnSubscribeList);
        }
    }
}

