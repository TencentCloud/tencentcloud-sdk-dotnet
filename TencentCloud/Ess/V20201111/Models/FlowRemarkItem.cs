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

    public class FlowRemarkItem : AbstractModel
    {
        
        /// <summary>
        /// <p>合同备注下标，对应最多5个备注位</p><p>取值范围：[0, 4]</p>
        /// </summary>
        [JsonProperty("RemarkId")]
        public long? RemarkId{ get; set; }

        /// <summary>
        /// <p>合同备注内容，不超过 50 个字符，DELETE 时无需传入</p>
        /// </summary>
        [JsonProperty("RemarkValue")]
        public string RemarkValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RemarkId", this.RemarkId);
            this.SetParamSimple(map, prefix + "RemarkValue", this.RemarkValue);
        }
    }
}

