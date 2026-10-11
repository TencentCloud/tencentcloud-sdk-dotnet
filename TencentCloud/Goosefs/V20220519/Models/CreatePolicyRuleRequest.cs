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

namespace TencentCloud.Goosefs.V20220519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePolicyRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>文件系统id</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>扫描目录</p>
        /// </summary>
        [JsonProperty("ScanDir")]
        public string ScanDir{ get; set; }

        /// <summary>
        /// <p>规则名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>执行计划</p>
        /// </summary>
        [JsonProperty("Execution")]
        public ExecutionPlan Execution{ get; set; }

        /// <summary>
        /// <p>过滤规则</p>
        /// </summary>
        [JsonProperty("PolicyRuleSet")]
        public PolicyRuleOperator[] PolicyRuleSet{ get; set; }

        /// <summary>
        /// <p>是否输出清单</p>
        /// </summary>
        [JsonProperty("EnableManifest")]
        public bool? EnableManifest{ get; set; }

        /// <summary>
        /// <p>清单配置</p>
        /// </summary>
        [JsonProperty("Manifest")]
        public ManifestAttr Manifest{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "ScanDir", this.ScanDir);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Execution.", this.Execution);
            this.SetParamArrayObj(map, prefix + "PolicyRuleSet.", this.PolicyRuleSet);
            this.SetParamSimple(map, prefix + "EnableManifest", this.EnableManifest);
            this.SetParamObj(map, prefix + "Manifest.", this.Manifest);
        }
    }
}

