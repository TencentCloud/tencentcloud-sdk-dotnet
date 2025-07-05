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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PeakNetwork : AbstractModel
    {
        
        /// <summary>
        /// 记录时间。
        /// </summary>
        [JsonProperty("RecordTime")]
        public string RecordTime{ get; set; }

        /// <summary>
        /// 入带宽数据。
        /// </summary>
        [JsonProperty("PeakInNetwork")]
        public string PeakInNetwork{ get; set; }

        /// <summary>
        /// 出带宽数据。
        /// </summary>
        [JsonProperty("PeakOutNetwork")]
        public string PeakOutNetwork{ get; set; }

        /// <summary>
        /// 计费带宽。单位bps
        /// </summary>
        [JsonProperty("ChargeNetwork")]
        public string ChargeNetwork{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordTime", this.RecordTime);
            this.SetParamSimple(map, prefix + "PeakInNetwork", this.PeakInNetwork);
            this.SetParamSimple(map, prefix + "PeakOutNetwork", this.PeakOutNetwork);
            this.SetParamSimple(map, prefix + "ChargeNetwork", this.ChargeNetwork);
        }
    }
}

