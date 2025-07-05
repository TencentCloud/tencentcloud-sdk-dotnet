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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSignUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方信息
        /// </summary>
        [JsonProperty("Caller")]
        public Caller Caller{ get; set; }

        /// <summary>
        /// 签署人ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 文件签署截止时间戳
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 目录ID。当 SignUrlType 为 CATALOG 时必填
        /// </summary>
        [JsonProperty("CatalogId")]
        public string CatalogId{ get; set; }

        /// <summary>
        /// 流程ID。当 SignUrlType 为 FLOW 时必填
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 签署链接类型：
        /// 1. FLOW - 单流程签署 (默认) 
        /// 2. CATALOG - 目录签署
        /// </summary>
        [JsonProperty("SignUrlType")]
        public string SignUrlType{ get; set; }

        /// <summary>
        /// 发送流程或目录时生成的签署任务ID
        /// </summary>
        [JsonProperty("SignId")]
        public string SignId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Caller.", this.Caller);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "CatalogId", this.CatalogId);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "SignUrlType", this.SignUrlType);
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
        }
    }
}

