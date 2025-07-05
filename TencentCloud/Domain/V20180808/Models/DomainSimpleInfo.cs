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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainSimpleInfo : AbstractModel
    {
        
        /// <summary>
        /// 域名资源ID。
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// 域名名称。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 域名实名认证状态。
        /// NotUpload：未实名认证
        /// InAudit：实名审核中
        /// Approved：实名审核通过
        /// Reject：实名审核失败
        /// NoAudit: 无需实名认证
        /// </summary>
        [JsonProperty("RealNameAuditStatus")]
        public string RealNameAuditStatus{ get; set; }

        /// <summary>
        /// 域名实名认证不通过原因。
        /// </summary>
        [JsonProperty("RealNameAuditUnpassReason")]
        public string RealNameAuditUnpassReason{ get; set; }

        /// <summary>
        /// 域名命名审核状态。
        /// NotAudit：命名审核未上传
        /// Pending：命名审核待上传
        /// Auditing：域名命名审核中
        /// Approved：域名命名审核通过
        /// Rejected：域名命名审核拒绝
        /// </summary>
        [JsonProperty("DomainNameAuditStatus")]
        public string DomainNameAuditStatus{ get; set; }

        /// <summary>
        /// 域名命名审核不通过原因。
        /// </summary>
        [JsonProperty("DomainNameAuditUnpassReason")]
        public string DomainNameAuditUnpassReason{ get; set; }

        /// <summary>
        /// 注册时间。
        /// </summary>
        [JsonProperty("CreationDate")]
        public string CreationDate{ get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public string ExpirationDate{ get; set; }

        /// <summary>
        /// 域名状态。
        /// ok：正常
        /// serverHold：注册局暂停解析 
        /// clientHold：注册商暂停解析
        /// pendingTransfer：转移中
        /// renewingPeriod：续费期
        /// redemptionPeriod：偿还期
        /// pendingDelete：删除期
        /// serverTransferProhibited：注册局禁止转移
        /// serverUpdateProhibited：注册局禁止更新
        /// serverDeleteProhibited：注册局禁止删除
        /// clientTransferProhibited：注册商禁止转移
        /// clientUpdateProhibited：注册商禁止更新
        /// clientDeleteProhibited：注册商禁止删除
        /// serverRenewProhibited: 注册局禁止续费
        /// clientRenewProhibited: 注册商禁止续费
        /// </summary>
        [JsonProperty("DomainStatus")]
        public string[] DomainStatus{ get; set; }

        /// <summary>
        /// 域名购买状态。
        /// ok：正常
        /// RegisterPending：待注册
        /// RegisterDoing：注册中
        /// RegisterFailed：注册失败
        /// AboutToExpire: 即将过期
        /// RenewPending：已进入续费期，需要进行续费
        /// RenewDoing：续费中
        /// RedemptionPending：已进入赎回期，需要进行续费
        /// RedemptionDoing：赎回中
        /// TransferPending：待转入中
        /// TransferTransing：转入中
        /// TransferFailed：转入失败
        /// </summary>
        [JsonProperty("BuyStatus")]
        public string BuyStatus{ get; set; }

        /// <summary>
        /// 注册商类型
        /// epp: DNSPod, Inc.（烟台帝思普网络科技有限公司）
        /// qcloud: Tencent Cloud Computing (Beijing) Limited Liability Company（腾讯云计算（北京）有限责任公司）
        /// yunxun: Guangzhou Yunxun Information Technology Co., Ltd.（广州云讯信息科技有限公司）
        /// xinnet: Xin Net Technology Corporation（北京新网数码信息技术有限公司）
        /// </summary>
        [JsonProperty("RegistrarType")]
        public string RegistrarType{ get; set; }

        /// <summary>
        /// 域名绑定的ns
        /// </summary>
        [JsonProperty("NameServer")]
        public string[] NameServer{ get; set; }

        /// <summary>
        /// true：开启锁定
        /// false：关闭锁定
        /// </summary>
        [JsonProperty("LockTransfer")]
        public bool? LockTransfer{ get; set; }

        /// <summary>
        /// 锁定结束时间
        /// </summary>
        [JsonProperty("LockEndTime")]
        public string LockEndTime{ get; set; }

        /// <summary>
        /// 认证类型：I=个人，E=企业
        /// </summary>
        [JsonProperty("RegistrantType")]
        public string RegistrantType{ get; set; }

        /// <summary>
        /// 域名所有者，中文
        /// </summary>
        [JsonProperty("OrganizationNameCN")]
        public string OrganizationNameCN{ get; set; }

        /// <summary>
        /// 域名所有者，英文
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 域名联系人，中文
        /// </summary>
        [JsonProperty("RegistrantNameCN")]
        public string RegistrantNameCN{ get; set; }

        /// <summary>
        /// 域名联系人，英文
        /// </summary>
        [JsonProperty("RegistrantName")]
        public string RegistrantName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "RealNameAuditStatus", this.RealNameAuditStatus);
            this.SetParamSimple(map, prefix + "RealNameAuditUnpassReason", this.RealNameAuditUnpassReason);
            this.SetParamSimple(map, prefix + "DomainNameAuditStatus", this.DomainNameAuditStatus);
            this.SetParamSimple(map, prefix + "DomainNameAuditUnpassReason", this.DomainNameAuditUnpassReason);
            this.SetParamSimple(map, prefix + "CreationDate", this.CreationDate);
            this.SetParamSimple(map, prefix + "ExpirationDate", this.ExpirationDate);
            this.SetParamArraySimple(map, prefix + "DomainStatus.", this.DomainStatus);
            this.SetParamSimple(map, prefix + "BuyStatus", this.BuyStatus);
            this.SetParamSimple(map, prefix + "RegistrarType", this.RegistrarType);
            this.SetParamArraySimple(map, prefix + "NameServer.", this.NameServer);
            this.SetParamSimple(map, prefix + "LockTransfer", this.LockTransfer);
            this.SetParamSimple(map, prefix + "LockEndTime", this.LockEndTime);
            this.SetParamSimple(map, prefix + "RegistrantType", this.RegistrantType);
            this.SetParamSimple(map, prefix + "OrganizationNameCN", this.OrganizationNameCN);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "RegistrantNameCN", this.RegistrantNameCN);
            this.SetParamSimple(map, prefix + "RegistrantName", this.RegistrantName);
        }
    }
}

