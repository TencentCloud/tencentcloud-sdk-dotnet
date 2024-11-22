/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class DescribeCasterPlayUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 导播台ID
        /// </summary>
        [JsonProperty("CasterId")]
        public ulong? CasterId{ get; set; }

        /// <summary>
        /// 请求播放url的类型。
        /// 取值范围[1，2，3]
        /// 1：获取输入源的播放url
        /// 2：获取pvw的播放url
        /// 3：获取pgm的播放url
        /// </summary>
        [JsonProperty("PlayUrlType")]
        public long? PlayUrlType{ get; set; }

        /// <summary>
        /// 仅在PlayUrlType为1时生效，此时该参数表示请求的输入源Index。
        /// 注：对应的输入源必须存在。
        /// </summary>
        [JsonProperty("PlayUrlIndex")]
        public long? PlayUrlIndex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CasterId", this.CasterId);
            this.SetParamSimple(map, prefix + "PlayUrlType", this.PlayUrlType);
            this.SetParamSimple(map, prefix + "PlayUrlIndex", this.PlayUrlIndex);
        }
    }
}

