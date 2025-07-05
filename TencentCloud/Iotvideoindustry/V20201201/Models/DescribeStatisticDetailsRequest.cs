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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStatisticDetailsRequest : AbstractModel
    {
        
        /// <summary>
        /// 开始日期，格式【YYYY-MM-DD】
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// 结束日期，格式【YYYY-MM-DD】
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// 统计项。取值范围：
        /// 1.录制设备数：RecordingDevice
        /// 2.非录制设备数：NonRecordingDevice
        /// 3.观看流量总数：WatchFlux
        /// 4.已用存储容量总数：StorageUsage
        /// 5. X-P2P分享流量: P2PFluxTotal
        /// 6. X-P2P峰值带宽: P2PPeakValue
        /// 7. RTMP推流路数(直播推流): LivePushTotal
        /// </summary>
        [JsonProperty("StatisticField")]
        public string StatisticField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "StatisticField", this.StatisticField);
        }
    }
}

