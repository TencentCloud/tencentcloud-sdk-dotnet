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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateStandardEngineResourceGroupBaseInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 引擎资源组名称
        /// </summary>
        [JsonProperty("EngineResourceGroupName")]
        public string EngineResourceGroupName{ get; set; }

        /// <summary>
        /// 自动启动，（任务提交自动拉起资源组）0-自动启动，1-不自动启动
        /// </summary>
        [JsonProperty("AutoLaunch")]
        public long? AutoLaunch{ get; set; }

        /// <summary>
        /// 自动挂起资源组。0-自动挂起，1-不自动挂起
        /// </summary>
        [JsonProperty("AutoPause")]
        public long? AutoPause{ get; set; }

        /// <summary>
        /// 自动挂起时间，单位分钟，取值范围在1-999（在无任务AutoPauseTime后，资源组自动挂起）
        /// </summary>
        [JsonProperty("AutoPauseTime")]
        public long? AutoPauseTime{ get; set; }

        /// <summary>
        /// 任务并发数
        /// </summary>
        [JsonProperty("MaxConcurrency")]
        public long? MaxConcurrency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineResourceGroupName", this.EngineResourceGroupName);
            this.SetParamSimple(map, prefix + "AutoLaunch", this.AutoLaunch);
            this.SetParamSimple(map, prefix + "AutoPause", this.AutoPause);
            this.SetParamSimple(map, prefix + "AutoPauseTime", this.AutoPauseTime);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
        }
    }
}

