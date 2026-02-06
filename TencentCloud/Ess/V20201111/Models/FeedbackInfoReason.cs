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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FeedbackInfoReason : AbstractModel
    {
        
        /// <summary>
        /// 反馈信息提取错误原因。
        /// `值如下`：
        /// - 1: 提取错误(提取不精准、提取为空等)
        /// - 2: 其他错误
        /// </summary>
        [JsonProperty("ReasonType")]
        public long? ReasonType{ get; set; }

        /// <summary>
        /// 反馈提取错误详细错误原因，不能超过500个字符
        /// </summary>
        [JsonProperty("ReasonContent")]
        public string ReasonContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReasonType", this.ReasonType);
            this.SetParamSimple(map, prefix + "ReasonContent", this.ReasonContent);
        }
    }
}

