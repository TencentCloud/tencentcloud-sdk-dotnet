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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BillUsageDetail : AbstractModel
    {
        
        /// <summary>
        /// 合同流程ID，为32位字符串。
        /// 建议开发者妥善保存此流程ID，以便于顺利进行后续操作。
        /// 可登录腾讯电子签控制台，在 "合同"->"合同中心" 中查看某个合同的FlowId(在页面中展示为合同ID)。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 合同经办人名称
        /// 如果有多个经办人用分号隔开。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperatorName")]
        public string OperatorName{ get; set; }

        /// <summary>
        /// 发起方组织机构名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateOrganizationName")]
        public string CreateOrganizationName{ get; set; }

        /// <summary>
        /// 合同流程的名称（可自定义此名称），长度不能超过200，只能由中文、字母、数字和下划线组成。
        /// 该名称还将用于合同签署完成后的下载文件名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 当前合同状态,如下是状态码对应的状态。
        /// 0-还没有发起
        /// 1-等待签署
        /// 2-部分签署 
        /// 3-拒签
        /// 4-已签署 
        /// 5-已过期 
        /// 6-已撤销 
        /// 7-还没有预发起
        /// 8-等待填写
        /// 9-部分填写 
        /// 10-拒填
        /// 11-已解除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 套餐类型
        /// 对应关系如下
        /// CloudEnterprise-企业版合同
        /// SingleSignature-单方签章
        /// CloudProve-签署报告
        /// CloudOnlineSign-腾讯会议在线签约
        /// ChannelWeCard-微工卡
        /// SignFlow-合同套餐
        /// SignFace-签署意愿（人脸识别）
        /// SignPassword-签署意愿（密码）
        /// SignSMS-签署意愿（短信）
        /// PersonalEssAuth-签署人实名（腾讯电子签认证）
        /// PersonalThirdAuth-签署人实名（信任第三方认证）
        /// OrgEssAuth-签署企业实名
        /// FlowNotify-短信通知
        /// AuthService-企业工商信息查询
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QuotaType")]
        public string QuotaType{ get; set; }

        /// <summary>
        /// 合同使用量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UseCount")]
        public long? UseCount{ get; set; }

        /// <summary>
        /// 消耗的时间戳，格式为Unix标准时间戳（秒）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CostTime")]
        public long? CostTime{ get; set; }

        /// <summary>
        /// 消耗的套餐名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QuotaName")]
        public string QuotaName{ get; set; }

        /// <summary>
        /// 消耗类型
        /// 1.扣费 2.撤销返还
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CostType")]
        public long? CostType{ get; set; }

        /// <summary>
        /// 备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
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

