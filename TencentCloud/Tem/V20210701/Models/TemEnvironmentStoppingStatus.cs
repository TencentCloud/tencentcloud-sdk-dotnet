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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemEnvironmentStoppingStatus : AbstractModel
    {
        
        /// <summary>
        /// 需要停止的应用数量
        /// </summary>
        [JsonProperty("ApplicationNumNeedToStop")]
        public long? ApplicationNumNeedToStop{ get; set; }

        /// <summary>
        /// 已经停止的应用数量
        /// </summary>
        [JsonProperty("StoppedApplicationNum")]
        public long? StoppedApplicationNum{ get; set; }

        /// <summary>
        /// 停止失败的应用数量
        /// </summary>
        [JsonProperty("StopFailedApplicationNum")]
        public long? StopFailedApplicationNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationNumNeedToStop", this.ApplicationNumNeedToStop);
            this.SetParamSimple(map, prefix + "StoppedApplicationNum", this.StoppedApplicationNum);
            this.SetParamSimple(map, prefix + "StopFailedApplicationNum", this.StopFailedApplicationNum);
        }
    }
}

