/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinalWorkflowOutputsDir")]
        public string FinalWorkflowOutputsDir{ get; set; }

        /// <summary>
        /// 是否使用相对目录归档输出。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UseRelativeOutputPaths")]
        public bool? UseRelativeOutputPaths{ get; set; }


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
        }
    }
}

