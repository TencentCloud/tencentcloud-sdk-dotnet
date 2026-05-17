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

    public class CosPolicyInfo : AbstractModel
    {
        
        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 策略类型
        /// PolicyType：1 告警策略 2 风险策略  3  白名单策略  4 ip隐藏策略
        /// </summary>
        [JsonProperty("PolicyType")]
        public long? PolicyType{ get; set; }

        /// <summary>
        /// system:系统内置 user:用户自定义
        /// </summary>
        [JsonProperty("PolicySource")]
        public long? PolicySource{ get; set; }

        /// <summary>
        /// 策略内容
        /// </summary>
        [JsonProperty("PolicyContent")]
        public string PolicyContent{ get; set; }

        /// <summary>
        /// 0 关闭
        /// 1 开启
        /// </summary>
        [JsonProperty("PolicyStatus")]
        public long? PolicyStatus{ get; set; }

        /// <summary>
        /// 策略分类
        /// </summary>
        [JsonProperty("PolicyAbnormalType")]
        public long? PolicyAbnormalType{ get; set; }

        /// <summary>
        /// 风险级别
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long? RiskLevel{ get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("PolicyCreateTime")]
        public long? PolicyCreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("PolicyUpdateTime")]
        public long? PolicyUpdateTime{ get; set; }

        /// <summary>
        /// 策略近七天命中次数
        /// </summary>
        [JsonProperty("PolicyHitCount")]
        public long? PolicyHitCount{ get; set; }

        /// <summary>
        /// 告警内容hash
        /// </summary>
        [JsonProperty("PolicyContentHash")]
        public string PolicyContentHash{ get; set; }

        /// <summary>
        /// 关联账户数
        /// </summary>
        [JsonProperty("RelAccountCount")]
        public long? RelAccountCount{ get; set; }

        /// <summary>
        /// 关联账号uin
        /// </summary>
        [JsonProperty("RelAccountUin")]
        public string RelAccountUin{ get; set; }

        /// <summary>
        /// 关联账号名
        /// </summary>
        [JsonProperty("RelAccountName")]
        public string RelAccountName{ get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("PolicyDescription")]
        public string PolicyDescription{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("PolicyMarker")]
        public string PolicyMarker{ get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 多账号场景下的id集合
        /// </summary>
        [JsonProperty("PolicyIdSet")]
        public long?[] PolicyIdSet{ get; set; }

        /// <summary>
        /// 是否处置历史数据状态  0 无须处置 1 需要处置 2 已处置
        /// </summary>
        [JsonProperty("PolicyHistoryHandleStatus")]
        public ulong? PolicyHistoryHandleStatus{ get; set; }

        /// <summary>
        /// 系统策略编辑状态
        /// </summary>
        [JsonProperty("SystemPolicyEditStatus")]
        public long? SystemPolicyEditStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "PolicySource", this.PolicySource);
            this.SetParamSimple(map, prefix + "PolicyContent", this.PolicyContent);
            this.SetParamSimple(map, prefix + "PolicyStatus", this.PolicyStatus);
            this.SetParamSimple(map, prefix + "PolicyAbnormalType", this.PolicyAbnormalType);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyCreateTime", this.PolicyCreateTime);
            this.SetParamSimple(map, prefix + "PolicyUpdateTime", this.PolicyUpdateTime);
            this.SetParamSimple(map, prefix + "PolicyHitCount", this.PolicyHitCount);
            this.SetParamSimple(map, prefix + "PolicyContentHash", this.PolicyContentHash);
            this.SetParamSimple(map, prefix + "RelAccountCount", this.RelAccountCount);
            this.SetParamSimple(map, prefix + "RelAccountUin", this.RelAccountUin);
            this.SetParamSimple(map, prefix + "RelAccountName", this.RelAccountName);
            this.SetParamSimple(map, prefix + "PolicyDescription", this.PolicyDescription);
            this.SetParamSimple(map, prefix + "PolicyMarker", this.PolicyMarker);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamArraySimple(map, prefix + "PolicyIdSet.", this.PolicyIdSet);
            this.SetParamSimple(map, prefix + "PolicyHistoryHandleStatus", this.PolicyHistoryHandleStatus);
            this.SetParamSimple(map, prefix + "SystemPolicyEditStatus", this.SystemPolicyEditStatus);
        }
    }
}

