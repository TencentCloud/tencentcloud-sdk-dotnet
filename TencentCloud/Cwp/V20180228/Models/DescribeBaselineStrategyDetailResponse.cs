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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBaselineStrategyDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 策略扫描通过率
        /// </summary>
        [JsonProperty("PassRate")]
        public ulong? PassRate{ get; set; }

        /// <summary>
        /// 策略名
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// 策略扫描周期(天)
        /// </summary>
        [JsonProperty("ScanCycle")]
        public string ScanCycle{ get; set; }

        /// <summary>
        /// 定期检测时间, 该时间下发扫描
        /// </summary>
        [JsonProperty("ScanAt")]
        public string ScanAt{ get; set; }

        /// <summary>
        /// 扫描范围是否全部服务器, 1:是  0:否, 为1则为全部专业版主机
        /// </summary>
        [JsonProperty("IsGlobal")]
        public ulong? IsGlobal{ get; set; }

        /// <summary>
        /// 云服务器类型：
        /// cvm：腾讯云服务器
        /// bm：裸金属
        /// ecm：边缘计算主机
        /// lh: 轻量应用服务器
        /// ohter: 混合云机器
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// 主机地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 用户该策略下的所有主机id
        /// </summary>
        [JsonProperty("Quuids")]
        public string[] Quuids{ get; set; }

        /// <summary>
        /// 用户该策略下所有的基线id
        /// </summary>
        [JsonProperty("CategoryIds")]
        public string[] CategoryIds{ get; set; }

        /// <summary>
        /// 1 表示扫描过, 0没扫描过
        /// </summary>
        [JsonProperty("IfScanned")]
        public ulong? IfScanned{ get; set; }

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
            this.SetParamSimple(map, prefix + "PassRate", this.PassRate);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "ScanCycle", this.ScanCycle);
            this.SetParamSimple(map, prefix + "ScanAt", this.ScanAt);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArraySimple(map, prefix + "Quuids.", this.Quuids);
            this.SetParamArraySimple(map, prefix + "CategoryIds.", this.CategoryIds);
            this.SetParamSimple(map, prefix + "IfScanned", this.IfScanned);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

