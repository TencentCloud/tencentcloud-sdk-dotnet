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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanInfo : AbstractModel
    {
        
        /// <summary>
        /// 扫描结果信息
        /// </summary>
        [JsonProperty("ScanResultInfo")]
        public ScanResultInfo ScanResultInfo{ get; set; }

        /// <summary>
        /// 扫描状态 0扫描中 1完成  2未勾选自动扫描
        /// </summary>
        [JsonProperty("ScanStatus")]
        public long? ScanStatus{ get; set; }

        /// <summary>
        /// 进度
        /// </summary>
        [JsonProperty("ScanPercent")]
        public float? ScanPercent{ get; set; }

        /// <summary>
        /// 预计完成时间
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ScanResultInfo.", this.ScanResultInfo);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "ScanPercent", this.ScanPercent);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
        }
    }
}

