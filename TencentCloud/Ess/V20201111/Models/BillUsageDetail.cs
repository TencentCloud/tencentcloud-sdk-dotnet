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

    public class BillUsageDetail : AbstractModel
    {
        
        /// <summary>
        /// 合同流程ID，为32位字符串。
        /// 可登录腾讯电子签控制台，在 "合同"->"合同中心" 中查看某个合同的FlowId(在页面中展示为合同ID)。
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 合同经办人名称
        /// 如果有多个经办人用分号隔开。
        /// </summary>
        [JsonProperty("OperatorName")]
        public string OperatorName{ get; set; }

        /// <summary>
        /// 发起方组织机构名称
        /// </summary>
        [JsonProperty("CreateOrganizationName")]
        public string CreateOrganizationName{ get; set; }

        /// <summary>
        /// 合同流程的名称。
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 当前合同状态,如下是状态码对应的状态。
        /// <ul>
        /// <li>**0**: 还没有发起</li>
        /// <li>**1**: 等待签署</li>
        /// <li>**2**: 部分签署 </li>
        /// <li>**3**: 拒签</li>
        /// <li>**4**: 已签署 </li>
        /// <li>**5**: 已过期 </li>
        /// <li>**6**: 已撤销 </li>
        /// <li>**7**: 还没有预发起</li>
        /// <li>**8**: 等待填写</li>
        /// <li>**9**: 部分填写 </li>
        /// <li>**10**: 拒签</li>
        /// <li>**11**: 已解除</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 查询的套餐类型
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
        /// 合同使用量
        /// 注: `如果消耗类型是撤销返还，此值为负值代表返还的合同数量`
        /// </summary>
        [JsonProperty("UseCount")]
        public long? UseCount{ get; set; }

        /// <summary>
        /// 消耗的时间戳，格式为Unix标准时间戳（秒）。
        /// </summary>
        [JsonProperty("CostTime")]
        public long? CostTime{ get; set; }

        /// <summary>
        /// 消耗的套餐名称
        /// </summary>
        [JsonProperty("QuotaName")]
        public string QuotaName{ get; set; }

        /// <summary>
        /// 消耗类型
        /// **1**.扣费
        /// **2**.撤销返还
        /// </summary>
        [JsonProperty("CostType")]
        public long? CostType{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "OperatorName", this.OperatorName);
            this.SetParamSimple(map, prefix + "CreateOrganizationName", this.CreateOrganizationName);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "QuotaType", this.QuotaType);
            this.SetParamSimple(map, prefix + "UseCount", this.UseCount);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "QuotaName", this.QuotaName);
            this.SetParamSimple(map, prefix + "CostType", this.CostType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

