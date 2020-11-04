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

namespace TencentCloud.Gpm.V20200820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// 匹配Code。
        /// </summary>
        [JsonProperty("MatchCode")]
        public string MatchCode{ get; set; }

        /// <summary>
        /// 单位秒，取值0-1800。此参数表示当前Token被替换后，GPM将持续推送原Token的时间。在CompatibleSpan时间范围内，用户将在事件消息中收到当前和原始Token。
        /// </summary>
        [JsonProperty("CompatibleSpan")]
        public ulong? CompatibleSpan{ get; set; }

        /// <summary>
        /// Token，[a-zA-Z0-9-_.], 长度0-64。如果为空，将由GPM随机生成。
        /// </summary>
        [JsonProperty("MatchToken")]
        public string MatchToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MatchCode", this.MatchCode);
            this.SetParamSimple(map, prefix + "CompatibleSpan", this.CompatibleSpan);
            this.SetParamSimple(map, prefix + "MatchToken", this.MatchToken);
        }
    }
}

