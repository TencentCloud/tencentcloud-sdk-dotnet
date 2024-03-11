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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetDiagnoseSettingsResponse : AbstractModel
    {
        
        /// <summary>
        /// 智能运维诊断项和元信息
        /// </summary>
        [JsonProperty("DiagnoseJobMetas")]
        public DiagnoseJobMeta[] DiagnoseJobMetas{ get; set; }

        /// <summary>
        /// 0：开启智能运维；-1：关闭智能运维
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 智能运维每天定时巡检时间
        /// </summary>
        [JsonProperty("CronTime")]
        public string CronTime{ get; set; }

        /// <summary>
        /// 智能运维当天已手动触发诊断次数
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 智能运维每天最大可手动触发次数
        /// </summary>
        [JsonProperty("MaxCount")]
        public long? MaxCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "DiagnoseJobMetas.", this.DiagnoseJobMetas);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CronTime", this.CronTime);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "MaxCount", this.MaxCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

