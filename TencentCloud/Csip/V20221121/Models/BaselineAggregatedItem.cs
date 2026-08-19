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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaselineAggregatedItem : AbstractModel
    {
        
        /// <summary>
        /// <p>检测项基础信息（含 ID、名称、风险等级、分类等）。</p>
        /// </summary>
        [JsonProperty("Item")]
        public BaselineItem Item{ get; set; }

        /// <summary>
        /// <p>该检测项最近一次扫描中结果为 PASS 的资产数量。</p>
        /// </summary>
        [JsonProperty("PassAssetCount")]
        public ulong? PassAssetCount{ get; set; }

        /// <summary>
        /// <p>该检测项最近一次扫描中结果为 NOT_PASS 的资产数量。</p>
        /// </summary>
        [JsonProperty("NotPassAssetCount")]
        public ulong? NotPassAssetCount{ get; set; }

        /// <summary>
        /// <p>该检测项最近一次扫描中结果为 PASS NOT_PASS 以及 CHECKING 的资产数量。</p>
        /// </summary>
        [JsonProperty("TotalAssetCount")]
        public ulong? TotalAssetCount{ get; set; }

        /// <summary>
        /// <p>该检测项最近一次扫描的资产通过率，单位为百分比（0~100）。</p>
        /// </summary>
        [JsonProperty("PassRate")]
        public float? PassRate{ get; set; }

        /// <summary>
        /// <p>该检测项最近一次完成扫描的时间。</p>
        /// </summary>
        [JsonProperty("LatestCheckTime")]
        public string LatestCheckTime{ get; set; }

        /// <summary>
        /// <p>上次扫描结果状态。取值：</p><ul><li>CHECKING：检测中</li><li>PASS：通过</li><li>NOT_PASS：未通过</li><li>CHECK_FAILED：检测失败</li><li>NOT_INVOLVED：不涉及</li></ul>
        /// </summary>
        [JsonProperty("ResultStatus")]
        public string ResultStatus{ get; set; }

        /// <summary>
        /// <p>该聚合结果涉及的租户 Appid 列表。</p>
        /// </summary>
        [JsonProperty("Appid")]
        public ulong?[] Appid{ get; set; }

        /// <summary>
        /// <p>该聚合结果涉及的扫描 JobID 列表。</p>
        /// </summary>
        [JsonProperty("JobID")]
        public string[] JobID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Item.", this.Item);
            this.SetParamSimple(map, prefix + "PassAssetCount", this.PassAssetCount);
            this.SetParamSimple(map, prefix + "NotPassAssetCount", this.NotPassAssetCount);
            this.SetParamSimple(map, prefix + "TotalAssetCount", this.TotalAssetCount);
            this.SetParamSimple(map, prefix + "PassRate", this.PassRate);
            this.SetParamSimple(map, prefix + "LatestCheckTime", this.LatestCheckTime);
            this.SetParamSimple(map, prefix + "ResultStatus", this.ResultStatus);
            this.SetParamArraySimple(map, prefix + "Appid.", this.Appid);
            this.SetParamArraySimple(map, prefix + "JobID.", this.JobID);
        }
    }
}

