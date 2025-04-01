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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFirmwareUpdateStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 升级任务源版本。
        /// </summary>
        [JsonProperty("OriVersion")]
        public string OriVersion{ get; set; }

        /// <summary>
        /// 升级任务目标版本。
        /// </summary>
        [JsonProperty("DstVersion")]
        public string DstVersion{ get; set; }

        /// <summary>
        /// 升级状态：- 0：设备离线。- 1：待处理。- 2：消息下发成功。- 3：下载中。- 4：烧录中。- 5：失败。- 6：升级完成。- 7：正在处理中。- 8：等待用户确认。- 10：升级超时。- 20：下载完成。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 进度
        /// </summary>
        [JsonProperty("Percent")]
        public long? Percent{ get; set; }

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
            this.SetParamSimple(map, prefix + "OriVersion", this.OriVersion);
            this.SetParamSimple(map, prefix + "DstVersion", this.DstVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

