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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RtmpPushInputInfo : AbstractModel
    {
        
        /// <summary>
        /// 直播推流地址有效期，单位：秒 。
        /// </summary>
        [JsonProperty("ExpiredSecond")]
        public ulong? ExpiredSecond{ get; set; }

        /// <summary>
        /// 直播推流地址，入参不填默认由多媒体创作引擎生成。
        /// </summary>
        [JsonProperty("PushUrl")]
        public string PushUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExpiredSecond", this.ExpiredSecond);
            this.SetParamSimple(map, prefix + "PushUrl", this.PushUrl);
        }
    }
}

