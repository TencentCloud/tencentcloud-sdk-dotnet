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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthCheckConfig : AbstractModel
    {
        
        /// <summary>
        /// 探测模式，默认值NQA，不可修改。
        /// </summary>
        [JsonProperty("ProbeType")]
        public string ProbeType{ get; set; }

        /// <summary>
        /// 探测间隔，腾讯云两次健康检查间隔时间，范围【1000-5000】，单位ms。
        /// </summary>
        [JsonProperty("ProbeInterval")]
        public long? ProbeInterval{ get; set; }

        /// <summary>
        /// 探测次数，连续N次健康检查失败后执行路由切换，范围【3-8】，单位次。
        /// </summary>
        [JsonProperty("ProbeThreshold")]
        public long? ProbeThreshold{ get; set; }

        /// <summary>
        /// 探测超时时间，范围【10-5000】，单位ms。
        /// </summary>
        [JsonProperty("ProbeTimeout")]
        public long? ProbeTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProbeType", this.ProbeType);
            this.SetParamSimple(map, prefix + "ProbeInterval", this.ProbeInterval);
            this.SetParamSimple(map, prefix + "ProbeThreshold", this.ProbeThreshold);
            this.SetParamSimple(map, prefix + "ProbeTimeout", this.ProbeTimeout);
        }
    }
}

