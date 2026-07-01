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

    public class RuleContentCmdLine : AbstractModel
    {
        
        /// <summary>
        /// <p>进程命令行信息</p>
        /// </summary>
        [JsonProperty("Process")]
        public RuleContentProcessInfo Process{ get; set; }

        /// <summary>
        /// <p>父进程命令行信息</p>
        /// </summary>
        [JsonProperty("ParentProcess")]
        public RuleContentProcessInfo ParentProcess{ get; set; }

        /// <summary>
        /// <p>祖先进程命令行信息</p>
        /// </summary>
        [JsonProperty("AncestorProcess")]
        public RuleContentProcessInfo AncestorProcess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Process.", this.Process);
            this.SetParamObj(map, prefix + "ParentProcess.", this.ParentProcess);
            this.SetParamObj(map, prefix + "AncestorProcess.", this.AncestorProcess);
        }
    }
}

