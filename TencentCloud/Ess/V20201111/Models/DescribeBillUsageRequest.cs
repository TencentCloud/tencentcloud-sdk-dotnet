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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBillUsageRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>查询开始时间字符串，格式为yyyymmdd,时间跨度不能大于90天</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>查询结束时间字符串，格式为yyyymmdd,时间跨度不能大于90天</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>查询的套餐类型 （选填 ）不传则查询所有套餐；目前支持:<ul><li><strong>CloudEnterprise</strong>: 企业版合同</li><li><strong>SingleSignature</strong>: 单方签章</li><li><strong>CloudProve</strong>: 签署报告</li><li><strong>CloudOnlineSign</strong>: 腾讯会议在线签约</li><li><strong>ChannelWeCard</strong>: 微工卡</li><li><strong>SignFlow</strong>: 合同套餐</li><li><strong>SignFace</strong>: 签署意愿（人脸识别）</li><li><strong>SignPassword</strong>: 签署意愿（密码）</li><li><strong>SignSMS</strong>: 签署意愿（短信）</li><li><strong>PersonalEssAuth</strong>: 签署人实名（腾讯电子签认证）</li><li><strong>PersonalThirdAuth</strong>: 签署人实名（信任第三方认证）</li><li><strong>OrgEssAuth</strong>: 签署企业实名</li><li><strong>FlowNotify</strong>: 短信通知</li><li><strong>AuthService</strong>: 企业工商信息查询</li></ul></p>
        /// </summary>
        [JsonProperty("QuotaType")]
        public string QuotaType{ get; set; }

        /// <summary>
        /// <p>是否展示集团子企业的明细，默认否</p>
        /// </summary>
        [JsonProperty("DisplaySubEnterprise")]
        public bool? DisplaySubEnterprise{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "QuotaType", this.QuotaType);
            this.SetParamSimple(map, prefix + "DisplaySubEnterprise", this.DisplaySubEnterprise);
        }
    }
}

