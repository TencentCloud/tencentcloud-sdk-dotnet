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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBaselineStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// 检测周期, 表示每隔多少天进行检测.示例: 2, 表示每2天进行检测一次.
        /// </summary>
        [JsonProperty("ScanCycle")]
        public ulong? ScanCycle{ get; set; }

        /// <summary>
        /// 定期检测时间，该时间下发扫描. 示例:“22:00”, 表示在22:00下发检测
        /// </summary>
        [JsonProperty("ScanAt")]
        public string ScanAt{ get; set; }

        /// <summary>
        /// 该策略下选择的基线id数组. 示例: [1,3,5,7]
        /// </summary>
        [JsonProperty("CategoryIds")]
        public ulong?[] CategoryIds{ get; set; }

        /// <summary>
        /// 扫描范围是否全部服务器, 1:是  0:否, 为1则为全部专业版主机
        /// </summary>
        [JsonProperty("IsGlobal")]
        public ulong? IsGlobal{ get; set; }

        /// <summary>
        /// 云主机类型：“CVM”：虚拟主机，"BMS"：裸金属，"ECM"：边缘计算主机
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// 主机地域. 示例: "ap-bj"
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// 主机id数组. 示例: ["quuid1","quuid2"]
        /// </summary>
        [JsonProperty("Quuids")]
        public string[] Quuids{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "ScanCycle", this.ScanCycle);
            this.SetParamSimple(map, prefix + "ScanAt", this.ScanAt);
            this.SetParamArraySimple(map, prefix + "CategoryIds.", this.CategoryIds);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamArraySimple(map, prefix + "Quuids.", this.Quuids);
        }
    }
}

