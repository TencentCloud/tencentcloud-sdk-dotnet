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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Probe : AbstractModel
    {
        
        /// <summary>
        /// 探针行为
        /// </summary>
        [JsonProperty("ProbeAction")]
        public ProbeAction ProbeAction{ get; set; }

        /// <summary>
        /// 等待服务启动的延迟
        /// </summary>
        [JsonProperty("InitialDelaySeconds")]
        public long? InitialDelaySeconds{ get; set; }

        /// <summary>
        /// 轮询检查时间间隔
        /// </summary>
        [JsonProperty("PeriodSeconds")]
        public long? PeriodSeconds{ get; set; }

        /// <summary>
        /// 检查超时时长
        /// </summary>
        [JsonProperty("TimeoutSeconds")]
        public long? TimeoutSeconds{ get; set; }

        /// <summary>
        /// 检测失败认定次数
        /// </summary>
        [JsonProperty("FailureThreshold")]
        public long? FailureThreshold{ get; set; }

        /// <summary>
        /// 检测成功认定次数，就绪默认 3，存活/启动默认 1
        /// </summary>
        [JsonProperty("SuccessThreshold")]
        public long? SuccessThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ProbeAction.", this.ProbeAction);
            this.SetParamSimple(map, prefix + "InitialDelaySeconds", this.InitialDelaySeconds);
            this.SetParamSimple(map, prefix + "PeriodSeconds", this.PeriodSeconds);
            this.SetParamSimple(map, prefix + "TimeoutSeconds", this.TimeoutSeconds);
            this.SetParamSimple(map, prefix + "FailureThreshold", this.FailureThreshold);
            this.SetParamSimple(map, prefix + "SuccessThreshold", this.SuccessThreshold);
        }
    }
}

