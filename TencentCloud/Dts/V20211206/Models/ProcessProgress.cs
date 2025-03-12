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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProcessProgress : AbstractModel
    {
        
        /// <summary>
        /// 步骤的状态， 包括：notStarted(未开始)、running(运行中)、success(成功)、failed(失败)等
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 进度信息
        /// </summary>
        [JsonProperty("Percent")]
        public ulong? Percent{ get; set; }

        /// <summary>
        /// 总的步骤数
        /// </summary>
        [JsonProperty("StepAll")]
        public ulong? StepAll{ get; set; }

        /// <summary>
        /// 当前进行的步骤
        /// </summary>
        [JsonProperty("StepNow")]
        public ulong? StepNow{ get; set; }

        /// <summary>
        /// 当前步骤输出提示信息
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 步骤信息
        /// </summary>
        [JsonProperty("Steps")]
        public StepDetailInfo[] Steps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "StepAll", this.StepAll);
            this.SetParamSimple(map, prefix + "StepNow", this.StepNow);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamArrayObj(map, prefix + "Steps.", this.Steps);
        }
    }
}

