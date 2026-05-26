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

    public class DescribeLicenseGeneralResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>总授权数 (包含隔离,过期等不可用状态)</p>
        /// </summary>
        [JsonProperty("LicenseCnt")]
        public ulong? LicenseCnt{ get; set; }

        /// <summary>
        /// <p>可用授权数</p>
        /// </summary>
        [JsonProperty("AvailableLicenseCnt")]
        public ulong? AvailableLicenseCnt{ get; set; }

        /// <summary>
        /// <p>可用专业版授权数(包含后付费).</p>
        /// </summary>
        [JsonProperty("AvailableProVersionLicenseCnt")]
        public ulong? AvailableProVersionLicenseCnt{ get; set; }

        /// <summary>
        /// <p>可用旗舰版授权数</p>
        /// </summary>
        [JsonProperty("AvailableFlagshipVersionLicenseCnt")]
        public ulong? AvailableFlagshipVersionLicenseCnt{ get; set; }

        /// <summary>
        /// <p>即将到期授权数 (15天内到期的)</p>
        /// </summary>
        [JsonProperty("NearExpiryLicenseCnt")]
        public ulong? NearExpiryLicenseCnt{ get; set; }

        /// <summary>
        /// <p>已到期授权数(不包含已删除的记录)</p>
        /// </summary>
        [JsonProperty("ExpireLicenseCnt")]
        public ulong? ExpireLicenseCnt{ get; set; }

        /// <summary>
        /// <p>自动升级开关状态,默认 false,  true 开启, false 关闭</p>
        /// </summary>
        [JsonProperty("AutoOpenStatus")]
        public bool? AutoOpenStatus{ get; set; }

        /// <summary>
        /// <p>PROVERSION_POSTPAY 专业版-后付费, PROVERSION_PREPAY 专业版-预付费, FLAGSHIP_PREPAY 旗舰版-预付费</p>
        /// </summary>
        [JsonProperty("ProtectType")]
        public string ProtectType{ get; set; }

        /// <summary>
        /// <p>历史是否开通过自动升级开关</p>
        /// </summary>
        [JsonProperty("IsOpenStatusHistory")]
        public bool? IsOpenStatusHistory{ get; set; }

        /// <summary>
        /// <p>已使用授权数</p>
        /// </summary>
        [JsonProperty("UsedLicenseCnt")]
        public ulong? UsedLicenseCnt{ get; set; }

        /// <summary>
        /// <p>未到期授权数</p>
        /// </summary>
        [JsonProperty("NotExpiredLicenseCnt")]
        public ulong? NotExpiredLicenseCnt{ get; set; }

        /// <summary>
        /// <p>旗舰版总授权数(有效订单)</p>
        /// </summary>
        [JsonProperty("FlagshipVersionLicenseCnt")]
        public ulong? FlagshipVersionLicenseCnt{ get; set; }

        /// <summary>
        /// <p>专业版总授权数(有效订单)</p>
        /// </summary>
        [JsonProperty("ProVersionLicenseCnt")]
        public ulong? ProVersionLicenseCnt{ get; set; }

        /// <summary>
        /// <p>轻量版总授权数(有效订单的授权数)</p>
        /// </summary>
        [JsonProperty("CwpVersionLicenseCnt")]
        public ulong? CwpVersionLicenseCnt{ get; set; }

        /// <summary>
        /// <p>可用惠普版授权数</p>
        /// </summary>
        [JsonProperty("AvailableLHLicenseCnt")]
        public ulong? AvailableLHLicenseCnt{ get; set; }

        /// <summary>
        /// <p>自动加购开关, true 开启, false 关闭</p>
        /// </summary>
        [JsonProperty("AutoRepurchaseSwitch")]
        public bool? AutoRepurchaseSwitch{ get; set; }

        /// <summary>
        /// <p>自动加购订单是否自动续费 ,true 开启, false 关闭</p>
        /// </summary>
        [JsonProperty("AutoRepurchaseRenewSwitch")]
        public bool? AutoRepurchaseRenewSwitch{ get; set; }

        /// <summary>
        /// <p>已销毁订单数</p>
        /// </summary>
        [JsonProperty("DestroyOrderNum")]
        public ulong? DestroyOrderNum{ get; set; }

        /// <summary>
        /// <p>自动加购是否自动续费开关,true 开启,false 关闭</p>
        /// </summary>
        [JsonProperty("RepurchaseRenewSwitch")]
        public bool? RepurchaseRenewSwitch{ get; set; }

        /// <summary>
        /// <p>是否自动新增机器绑定rasp防护,false 关闭 true 开启</p>
        /// </summary>
        [JsonProperty("AutoBindRaspSwitch")]
        public bool? AutoBindRaspSwitch{ get; set; }

        /// <summary>
        /// <p>是否自动新增机器开启rasp防护,false 关闭 true 开启</p>
        /// </summary>
        [JsonProperty("AutoOpenRaspSwitch")]
        public bool? AutoOpenRaspSwitch{ get; set; }

        /// <summary>
        /// <p>是否自动缩容开关开启</p>
        /// </summary>
        [JsonProperty("AutoDowngradeSwitch")]
        public bool? AutoDowngradeSwitch{ get; set; }

        /// <summary>
        /// <p>可使用的AI防护版授权数</p>
        /// </summary>
        [JsonProperty("AvailableAISecurityLicenseCnt")]
        public ulong? AvailableAISecurityLicenseCnt{ get; set; }

        /// <summary>
        /// <p>AI 防护版总授权数</p>
        /// </summary>
        [JsonProperty("AISecurityVersionLicenseCnt")]
        public ulong? AISecurityVersionLicenseCnt{ get; set; }

        /// <summary>
        /// <p>应用防护授权数+旗舰版授权数相加后的可使用授权数</p>
        /// </summary>
        [JsonProperty("ApplicationAvailableLicenseCnt")]
        public ulong? ApplicationAvailableLicenseCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "LicenseCnt", this.LicenseCnt);
            this.SetParamSimple(map, prefix + "AvailableLicenseCnt", this.AvailableLicenseCnt);
            this.SetParamSimple(map, prefix + "AvailableProVersionLicenseCnt", this.AvailableProVersionLicenseCnt);
            this.SetParamSimple(map, prefix + "AvailableFlagshipVersionLicenseCnt", this.AvailableFlagshipVersionLicenseCnt);
            this.SetParamSimple(map, prefix + "NearExpiryLicenseCnt", this.NearExpiryLicenseCnt);
            this.SetParamSimple(map, prefix + "ExpireLicenseCnt", this.ExpireLicenseCnt);
            this.SetParamSimple(map, prefix + "AutoOpenStatus", this.AutoOpenStatus);
            this.SetParamSimple(map, prefix + "ProtectType", this.ProtectType);
            this.SetParamSimple(map, prefix + "IsOpenStatusHistory", this.IsOpenStatusHistory);
            this.SetParamSimple(map, prefix + "UsedLicenseCnt", this.UsedLicenseCnt);
            this.SetParamSimple(map, prefix + "NotExpiredLicenseCnt", this.NotExpiredLicenseCnt);
            this.SetParamSimple(map, prefix + "FlagshipVersionLicenseCnt", this.FlagshipVersionLicenseCnt);
            this.SetParamSimple(map, prefix + "ProVersionLicenseCnt", this.ProVersionLicenseCnt);
            this.SetParamSimple(map, prefix + "CwpVersionLicenseCnt", this.CwpVersionLicenseCnt);
            this.SetParamSimple(map, prefix + "AvailableLHLicenseCnt", this.AvailableLHLicenseCnt);
            this.SetParamSimple(map, prefix + "AutoRepurchaseSwitch", this.AutoRepurchaseSwitch);
            this.SetParamSimple(map, prefix + "AutoRepurchaseRenewSwitch", this.AutoRepurchaseRenewSwitch);
            this.SetParamSimple(map, prefix + "DestroyOrderNum", this.DestroyOrderNum);
            this.SetParamSimple(map, prefix + "RepurchaseRenewSwitch", this.RepurchaseRenewSwitch);
            this.SetParamSimple(map, prefix + "AutoBindRaspSwitch", this.AutoBindRaspSwitch);
            this.SetParamSimple(map, prefix + "AutoOpenRaspSwitch", this.AutoOpenRaspSwitch);
            this.SetParamSimple(map, prefix + "AutoDowngradeSwitch", this.AutoDowngradeSwitch);
            this.SetParamSimple(map, prefix + "AvailableAISecurityLicenseCnt", this.AvailableAISecurityLicenseCnt);
            this.SetParamSimple(map, prefix + "AISecurityVersionLicenseCnt", this.AISecurityVersionLicenseCnt);
            this.SetParamSimple(map, prefix + "ApplicationAvailableLicenseCnt", this.ApplicationAvailableLicenseCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

