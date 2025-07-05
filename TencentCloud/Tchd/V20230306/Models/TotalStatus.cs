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

namespace TencentCloud.Tchd.V20230306.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TotalStatus : AbstractModel
    {
        
        /// <summary>
        /// 正常状态的数目
        /// </summary>
        [JsonProperty("NormalCount")]
        public long? NormalCount{ get; set; }

        /// <summary>
        /// 通知状态的数目
        /// </summary>
        [JsonProperty("NotifyCount")]
        public long? NotifyCount{ get; set; }

        /// <summary>
        /// 异常状态的数目
        /// </summary>
        [JsonProperty("AbnormalCount")]
        public long? AbnormalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NormalCount", this.NormalCount);
            this.SetParamSimple(map, prefix + "NotifyCount", this.NotifyCount);
            this.SetParamSimple(map, prefix + "AbnormalCount", this.AbnormalCount);
        }
    }
}

