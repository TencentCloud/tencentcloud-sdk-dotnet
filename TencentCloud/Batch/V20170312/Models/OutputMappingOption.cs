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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputMappingOption : AbstractModel
    {
        
        /// <summary>
        /// 容器场景下,输出选项从实例映射到容器内的实例侧的工作空间。
        /// BATCH_WORKSPACE: 工作空间为BATCH在实例内定义的工作空间，BATCH侧保证作业之间的隔离。（默认）
        /// GLOBAL_WORKSPACE: 工作空间为实例操作系统空间。
        /// </summary>
        [JsonProperty("Workspace")]
        public string Workspace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Workspace", this.Workspace);
        }
    }
}

