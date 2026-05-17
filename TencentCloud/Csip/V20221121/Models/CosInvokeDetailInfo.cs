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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosInvokeDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 调用时间
        /// </summary>
        [JsonProperty("InvokeTimestamp")]
        public long? InvokeTimestamp{ get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [JsonProperty("InvokeRequestId")]
        public string InvokeRequestId{ get; set; }

        /// <summary>
        /// 调用内容
        /// </summary>
        [JsonProperty("InvokeContent")]
        public string InvokeContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvokeTimestamp", this.InvokeTimestamp);
            this.SetParamSimple(map, prefix + "InvokeRequestId", this.InvokeRequestId);
            this.SetParamSimple(map, prefix + "InvokeContent", this.InvokeContent);
        }
    }
}

