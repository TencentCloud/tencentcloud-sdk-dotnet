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

    public class FlowOperateLimit : AbstractModel
    {
        
        /// <summary>
        /// 发起合同流程时，对签署完成后是否能发起对应的解除合同加以限制：<ul><li><b>false（默认值）</b>: 合同流程完成签署后，支持发起对应的解除协议。</li><li><b>true </b>: 合同流程完成签署后，<b>不支持</b>发起对应的解除协议。</li></ul>
        /// </summary>
        [JsonProperty("NoRelease")]
        public bool? NoRelease{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NoRelease", this.NoRelease);
        }
    }
}

