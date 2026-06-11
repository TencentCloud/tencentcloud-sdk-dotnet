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

    public class DescribeMachineGeneralResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>资产总数</p>
        /// </summary>
        [JsonProperty("MachineCnt")]
        public ulong? MachineCnt{ get; set; }

        /// <summary>
        /// <p>腾讯云服务商机器数</p>
        /// </summary>
        [JsonProperty("TencentCloudMachineCnt")]
        [System.Obsolete]
        public ulong? TencentCloudMachineCnt{ get; set; }

        /// <summary>
        /// <p>阿里云服务商机器数</p>
        /// </summary>
        [JsonProperty("AliCloudMachineCnt")]
        [System.Obsolete]
        public ulong? AliCloudMachineCnt{ get; set; }

        /// <summary>
        /// <p>百度云服务商机器数</p>
        /// </summary>
        [JsonProperty("BaiduCloudMachineCnt")]
        [System.Obsolete]
        public ulong? BaiduCloudMachineCnt{ get; set; }

        /// <summary>
        /// <p>IDC机器数</p>
        /// </summary>
        [JsonProperty("IDCMachineCnt")]
        [System.Obsolete]
        public ulong? IDCMachineCnt{ get; set; }

        /// <summary>
        /// <p>其他云服务商机器数</p>
        /// </summary>
        [JsonProperty("OtherCloudMachineCnt")]
        [System.Obsolete]
        public ulong? OtherCloudMachineCnt{ get; set; }

        /// <summary>
        /// <p>已防护机器数</p>
        /// </summary>
        [JsonProperty("ProtectMachineCnt")]
        public ulong? ProtectMachineCnt{ get; set; }

        /// <summary>
        /// <p>已防护基础版机器数</p>
        /// </summary>
        [JsonProperty("BaseMachineCnt")]
        public ulong? BaseMachineCnt{ get; set; }

        /// <summary>
        /// <p>已防护专业版机器数</p>
        /// </summary>
        [JsonProperty("SpecialtyMachineCnt")]
        public ulong? SpecialtyMachineCnt{ get; set; }

        /// <summary>
        /// <p>已防护旗舰版机器数</p>
        /// </summary>
        [JsonProperty("FlagshipMachineCnt")]
        public ulong? FlagshipMachineCnt{ get; set; }

        /// <summary>
        /// <p>存在风险的机器数</p>
        /// </summary>
        [JsonProperty("RiskMachineCnt")]
        public ulong? RiskMachineCnt{ get; set; }

        /// <summary>
        /// <p>比较昨日风险机器数</p>
        /// </summary>
        [JsonProperty("CompareYesterdayRiskMachineCnt")]
        public long? CompareYesterdayRiskMachineCnt{ get; set; }

        /// <summary>
        /// <p>比较昨日未防护机器数</p>
        /// </summary>
        [JsonProperty("CompareYesterdayNotProtectMachineCnt")]
        public long? CompareYesterdayNotProtectMachineCnt{ get; set; }

        /// <summary>
        /// <p>比较昨日即将到期的机器数</p>
        /// </summary>
        [JsonProperty("CompareYesterdayDeadlineMachineCnt")]
        public long? CompareYesterdayDeadlineMachineCnt{ get; set; }

        /// <summary>
        /// <p>即将到期的机器数</p>
        /// </summary>
        [JsonProperty("DeadlineMachineCnt")]
        public ulong? DeadlineMachineCnt{ get; set; }

        /// <summary>
        /// <p>未防护机器数</p>
        /// </summary>
        [JsonProperty("NotProtectMachineCnt")]
        public ulong? NotProtectMachineCnt{ get; set; }

        /// <summary>
        /// <p>已防护轻量机器数（Lighthouse机器）</p>
        /// </summary>
        [JsonProperty("LHGeneralDiscountCnt")]
        public ulong? LHGeneralDiscountCnt{ get; set; }

        /// <summary>
        /// <p>比较昨日新增的主机数</p>
        /// </summary>
        [JsonProperty("CompareYesterdayMachineCnt")]
        public long? CompareYesterdayMachineCnt{ get; set; }

        /// <summary>
        /// <p>自动清理时间,最大720小时,最小0, 默认0 ,0=关闭</p>
        /// </summary>
        [JsonProperty("MachineDestroyAfterOfflineHours")]
        public ulong? MachineDestroyAfterOfflineHours{ get; set; }

        /// <summary>
        /// <p>云服务器类型数组</p>
        /// </summary>
        [JsonProperty("CloudFrom")]
        public CloudFromCnt[] CloudFrom{ get; set; }

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
            this.SetParamSimple(map, prefix + "MachineCnt", this.MachineCnt);
            this.SetParamSimple(map, prefix + "TencentCloudMachineCnt", this.TencentCloudMachineCnt);
            this.SetParamSimple(map, prefix + "AliCloudMachineCnt", this.AliCloudMachineCnt);
            this.SetParamSimple(map, prefix + "BaiduCloudMachineCnt", this.BaiduCloudMachineCnt);
            this.SetParamSimple(map, prefix + "IDCMachineCnt", this.IDCMachineCnt);
            this.SetParamSimple(map, prefix + "OtherCloudMachineCnt", this.OtherCloudMachineCnt);
            this.SetParamSimple(map, prefix + "ProtectMachineCnt", this.ProtectMachineCnt);
            this.SetParamSimple(map, prefix + "BaseMachineCnt", this.BaseMachineCnt);
            this.SetParamSimple(map, prefix + "SpecialtyMachineCnt", this.SpecialtyMachineCnt);
            this.SetParamSimple(map, prefix + "FlagshipMachineCnt", this.FlagshipMachineCnt);
            this.SetParamSimple(map, prefix + "RiskMachineCnt", this.RiskMachineCnt);
            this.SetParamSimple(map, prefix + "CompareYesterdayRiskMachineCnt", this.CompareYesterdayRiskMachineCnt);
            this.SetParamSimple(map, prefix + "CompareYesterdayNotProtectMachineCnt", this.CompareYesterdayNotProtectMachineCnt);
            this.SetParamSimple(map, prefix + "CompareYesterdayDeadlineMachineCnt", this.CompareYesterdayDeadlineMachineCnt);
            this.SetParamSimple(map, prefix + "DeadlineMachineCnt", this.DeadlineMachineCnt);
            this.SetParamSimple(map, prefix + "NotProtectMachineCnt", this.NotProtectMachineCnt);
            this.SetParamSimple(map, prefix + "LHGeneralDiscountCnt", this.LHGeneralDiscountCnt);
            this.SetParamSimple(map, prefix + "CompareYesterdayMachineCnt", this.CompareYesterdayMachineCnt);
            this.SetParamSimple(map, prefix + "MachineDestroyAfterOfflineHours", this.MachineDestroyAfterOfflineHours);
            this.SetParamArrayObj(map, prefix + "CloudFrom.", this.CloudFrom);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

