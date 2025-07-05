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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunOption : AbstractModel
    {
        
        /// <summary>
        /// 运行失败模式，取值范围：
        /// - ContinueWhilePossible
        /// - NoNewCalls
        /// </summary>
        [JsonProperty("FailureMode")]
        public string FailureMode{ get; set; }

        /// <summary>
        /// 是否使用Call-Caching功能。
        /// </summary>
        [JsonProperty("UseCallCache")]
        public bool? UseCallCache{ get; set; }

        /// <summary>
        /// 是否使用错误挂起功能。
        /// </summary>
        [JsonProperty("UseErrorOnHold")]
        public bool? UseErrorOnHold{ get; set; }

        /// <summary>
        /// 输出归档COS路径。
        /// </summary>
        [JsonProperty("FinalWorkflowOutputsDir")]
        public string FinalWorkflowOutputsDir{ get; set; }

        /// <summary>
        /// 是否使用相对目录归档输出。
        /// </summary>
        [JsonProperty("UseRelativeOutputPaths")]
        public bool? UseRelativeOutputPaths{ get; set; }

        /// <summary>
        /// 是否添加运行信息到输出目录中
        /// </summary>
        [JsonProperty("AddRunInfoToOutputDir")]
        public bool? AddRunInfoToOutputDir{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FailureMode", this.FailureMode);
            this.SetParamSimple(map, prefix + "UseCallCache", this.UseCallCache);
            this.SetParamSimple(map, prefix + "UseErrorOnHold", this.UseErrorOnHold);
            this.SetParamSimple(map, prefix + "FinalWorkflowOutputsDir", this.FinalWorkflowOutputsDir);
            this.SetParamSimple(map, prefix + "UseRelativeOutputPaths", this.UseRelativeOutputPaths);
            this.SetParamSimple(map, prefix + "AddRunInfoToOutputDir", this.AddRunInfoToOutputDir);
        }
    }
}

