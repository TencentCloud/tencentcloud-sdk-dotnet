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

    public class ModelTestResult : AbstractModel
    {
        
        /// <summary>
        /// <p>模型</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>健康状况</p><p>枚举值：</p><ul><li>Success： 健康</li><li>Error： 不健康</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>错误信息</p>
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public ProviderTestConnectionErrorInfo ErrorInfo{ get; set; }

        /// <summary>
        /// <p>探测请求</p>
        /// </summary>
        [JsonProperty("TestConnectionRequest")]
        public TestConnectionRequestInfo TestConnectionRequest{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "ErrorInfo.", this.ErrorInfo);
            this.SetParamObj(map, prefix + "TestConnectionRequest.", this.TestConnectionRequest);
        }
    }
}

