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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskGroupInstancesExecuteRules : AbstractModel
    {
        
        /// <summary>
        /// 实例选取模式
        /// </summary>
        [JsonProperty("TaskGroupInstancesExecuteMode")]
        public long? TaskGroupInstancesExecuteMode{ get; set; }

        /// <summary>
        /// 按比例选取模式下选取比例
        /// </summary>
        [JsonProperty("TaskGroupInstancesExecutePercent")]
        public long? TaskGroupInstancesExecutePercent{ get; set; }

        /// <summary>
        /// 按数量选取模式下选取数量
        /// </summary>
        [JsonProperty("TaskGroupInstancesExecuteNum")]
        public long? TaskGroupInstancesExecuteNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskGroupInstancesExecuteMode", this.TaskGroupInstancesExecuteMode);
            this.SetParamSimple(map, prefix + "TaskGroupInstancesExecutePercent", this.TaskGroupInstancesExecutePercent);
            this.SetParamSimple(map, prefix + "TaskGroupInstancesExecuteNum", this.TaskGroupInstancesExecuteNum);
        }
    }
}

