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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TestModelInputModalitiesResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>探测的模型</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>该模型确认支持的输入模态列表</p><p>枚举值：</p><ul><li>text： 支持文本输入</li><li>image： 支持图像输入</li><li>file： 支持文件输入（当前仅支持pdf）</li></ul><p>收到上游大模型对于输入模态的响应即为“确认支持”</p>
        /// </summary>
        [JsonProperty("SupportedModalities")]
        public string[] SupportedModalities{ get; set; }

        /// <summary>
        /// <p>每个待探测模态的详细请求结果</p>
        /// </summary>
        [JsonProperty("ProbeDetails")]
        public ModalityProbeDetail[] ProbeDetails{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArraySimple(map, prefix + "SupportedModalities.", this.SupportedModalities);
            this.SetParamArrayObj(map, prefix + "ProbeDetails.", this.ProbeDetails);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

