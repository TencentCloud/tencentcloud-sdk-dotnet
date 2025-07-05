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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportScanTaskDetailsRequest : AbstractModel
    {
        
        /// <summary>
        /// 本次检测的任务id（不同于出参的导出本次检测Excel的任务Id）
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 模块类型，当前提供：Malware 木马 , Vul 漏洞 , Baseline 基线
        /// </summary>
        [JsonProperty("ModuleType")]
        public string ModuleType{ get; set; }

        /// <summary>
        /// 过滤参数：ipOrAlias（服务器名/ip）
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "ModuleType", this.ModuleType);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

