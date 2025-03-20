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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskDetail : AbstractModel
    {
        
        /// <summary>
        /// 当前执行的子任务步骤名称。
        /// </summary>
        [JsonProperty("CurrentStep")]
        public string CurrentStep{ get; set; }

        /// <summary>
        /// 当前任务所拥有的子步骤描述。
        /// </summary>
        [JsonProperty("AllSteps")]
        public string AllSteps{ get; set; }

        /// <summary>
        /// 任务的输入参数。
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// 任务的输出参数。
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// 指定实例配置完成变更后的切换时间，默认值：0
        /// 0:   此任务不需要切换
        /// 1：立即切换
        /// 2：指定时间切换
        /// 3：维护时间窗口内切换。
        /// </summary>
        [JsonProperty("SwitchTag")]
        public ulong? SwitchTag{ get; set; }

        /// <summary>
        /// 指定的切换时间。
        /// </summary>
        [JsonProperty("SwitchTime")]
        public string SwitchTime{ get; set; }

        /// <summary>
        /// 任务的提示信息。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CurrentStep", this.CurrentStep);
            this.SetParamSimple(map, prefix + "AllSteps", this.AllSteps);
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "SwitchTag", this.SwitchTag);
            this.SetParamSimple(map, prefix + "SwitchTime", this.SwitchTime);
            this.SetParamSimple(map, prefix + "Message", this.Message);
        }
    }
}

