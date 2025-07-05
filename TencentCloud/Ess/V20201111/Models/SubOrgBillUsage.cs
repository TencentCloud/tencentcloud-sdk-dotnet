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

    public class SubOrgBillUsage : AbstractModel
    {
        
        /// <summary>
        /// 套餐使用数
        /// </summary>
        [JsonProperty("Used")]
        public long? Used{ get; set; }

        /// <summary>
        /// 套餐类型
        /// 对应关系如下:
        /// <ul>
        /// <li>**CloudEnterprise**: 企业版合同</li>
        /// <li>**SingleSignature**: 单方签章</li>
        /// <li>**CloudProve**: 签署报告</li>
        /// <li>**CloudOnlineSign**: 腾讯会议在线签约</li>
        /// <li>**ChannelWeCard**: 微工卡</li>
        /// <li>**SignFlow**: 合同套餐</li>
        /// <li>**SignFace**: 签署意愿（人脸识别）</li>
        /// <li>**SignPassword**: 签署意愿（密码）</li>
        /// <li>**SignSMS**: 签署意愿（短信）</li>
        /// <li>**PersonalEssAuth**: 签署人实名（腾讯电子签认证）</li>
        /// <li>**PersonalThirdAuth**: 签署人实名（信任第三方认证）</li>
        /// <li>**OrgEssAuth**: 签署企业实名</li>
        /// <li>**FlowNotify**: 短信通知</li>
        /// <li>**AuthService**: 企业工商信息查询</li>
        /// </ul>
        /// </summary>
        [JsonProperty("QuotaType")]
        public string QuotaType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Used", this.Used);
            this.SetParamSimple(map, prefix + "QuotaType", this.QuotaType);
        }
    }
}

