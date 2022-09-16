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

    public class DescribeLicenseGeneralResponse : AbstractModel
    {
        
        /// <summary>
        /// 总授权数 (包含隔离,过期等不可用状态)
        /// </summary>
        [JsonProperty("LicenseCnt")]
        public ulong? LicenseCnt{ get; set; }

        /// <summary>
        /// 可用授权数
        /// </summary>
        [JsonProperty("AvailableLicenseCnt")]
        public ulong? AvailableLicenseCnt{ get; set; }

        /// <summary>
        /// 可用专业版授权数(包含后付费).
        /// </summary>
        [JsonProperty("AvailableProVersionLicenseCnt")]
        public ulong? AvailableProVersionLicenseCnt{ get; set; }

        /// <summary>
        /// 可用旗舰版授权数
        /// </summary>
        [JsonProperty("AvailableFlagshipVersionLicenseCnt")]
        public ulong? AvailableFlagshipVersionLicenseCnt{ get; set; }

        /// <summary>
        /// 即将到期授权数 (15天内到期的)
        /// </summary>
        [JsonProperty("NearExpiryLicenseCnt")]
        public ulong? NearExpiryLicenseCnt{ get; set; }

        /// <summary>
        /// 已到期授权数(不包含已删除的记录)
        /// </summary>
        [JsonProperty("ExpireLicenseCnt")]
        public ulong? ExpireLicenseCnt{ get; set; }

        /// <summary>
        /// 自动升级开关状态,默认 false,  true 开启, false 关闭
        /// </summary>
        [JsonProperty("AutoOpenStatus")]
        public bool? AutoOpenStatus{ get; set; }

        /// <summary>
        /// PROVERSION_POSTPAY 专业版-后付费, PROVERSION_PREPAY 专业版-预付费, FLAGSHIP_PREPAY 旗舰版-预付费
        /// </summary>
        [JsonProperty("ProtectType")]
        public string ProtectType{ get; set; }

        /// <summary>
        /// 历史是否开通过自动升级开关
        /// </summary>
        [JsonProperty("IsOpenStatusHistory")]
        public bool? IsOpenStatusHistory{ get; set; }

        /// <summary>
        /// 已使用授权数
        /// </summary>
        [JsonProperty("UsedLicenseCnt")]
        public ulong? UsedLicenseCnt{ get; set; }

        /// <summary>
        /// 未到期授权数
        /// </summary>
        [JsonProperty("NotExpiredLicenseCnt")]
        public ulong? NotExpiredLicenseCnt{ get; set; }

        /// <summary>
        /// 旗舰版总授权数(有效订单)
        /// </summary>
        [JsonProperty("FlagshipVersionLicenseCnt")]
        public ulong? FlagshipVersionLicenseCnt{ get; set; }

        /// <summary>
        /// 专业版总授权数(有效订单)
        /// </summary>
        [JsonProperty("ProVersionLicenseCnt")]
        public ulong? ProVersionLicenseCnt{ get; set; }

        /// <summary>
        /// 普惠版总授权数(有效订单的授权数)
        /// </summary>
        [JsonProperty("CwpVersionLicenseCnt")]
        public ulong? CwpVersionLicenseCnt{ get; set; }

        /// <summary>
        /// 可用惠普版授权数
        /// </summary>
        [JsonProperty("AvailableLHLicenseCnt")]
        public ulong? AvailableLHLicenseCnt{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

