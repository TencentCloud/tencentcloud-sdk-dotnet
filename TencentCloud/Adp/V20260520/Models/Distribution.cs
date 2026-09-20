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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Distribution : AbstractModel
    {
        
        /// <summary>
        /// <p>该回复方式的调用次数</p>
        /// </summary>
        [JsonProperty("CallCount")]
        public string CallCount{ get; set; }

        /// <summary>
        /// <p>该回复方式在总调用次数中的占比（百分比，0~100，保留两位小数；无数据时全为 0，有数据时各项之和为 100）</p>
        /// </summary>
        [JsonProperty("Percentage")]
        public float? Percentage{ get; set; }

        /// <summary>
        /// <p>回复方式名称（已按请求语言国际化；i18n 缺失时兜底为 reply_method 的枚举名）</p>
        /// </summary>
        [JsonProperty("ReplyName")]
        public string ReplyName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallCount", this.CallCount);
            this.SetParamSimple(map, prefix + "Percentage", this.Percentage);
            this.SetParamSimple(map, prefix + "ReplyName", this.ReplyName);
        }
    }
}

