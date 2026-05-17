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

    public class CosAlarmInfo : AbstractModel
    {
        
        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 策略类型 0-未知规则分类(Unknown), 1-异常行为(AbnormalBehavior), 2-权限过大(ExcessivePermission), 3-资源枚举(ResourceEnumerated), 4-匿名访问(AnonymousAccess)
        /// </summary>
        [JsonProperty("PolicyAbnormalType")]
        public long? PolicyAbnormalType{ get; set; }

        /// <summary>
        /// 风险等级：0:Normal, 1:Tip, 2:Low, 3:Middle, 4:High, 5:Critical
        /// </summary>
        [JsonProperty("PolicyRiskLevel")]
        public long? PolicyRiskLevel{ get; set; }

        /// <summary>
        /// 策略信息描述
        /// </summary>
        [JsonProperty("PolicyDescription")]
        public string PolicyDescription{ get; set; }

        /// <summary>
        /// 桶名
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 桶地域
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// 桶备注
        /// </summary>
        [JsonProperty("BucketMarker")]
        public string BucketMarker{ get; set; }

        /// <summary>
        /// 桶tag信息
        /// </summary>
        [JsonProperty("BucketTagInfo")]
        public string BucketTagInfo{ get; set; }

        /// <summary>
        /// 桶可访问属性
        /// </summary>
        [JsonProperty("BucketAccessWay")]
        public string BucketAccessWay{ get; set; }

        /// <summary>
        /// 所属账号uin
        /// </summary>
        [JsonProperty("AccountUin")]
        public string AccountUin{ get; set; }

        /// <summary>
        /// 所属账号昵称
        /// </summary>
        [JsonProperty("AccountNickName")]
        public string AccountNickName{ get; set; }

        /// <summary>
        /// 所属账号社身份 1 主 2子
        /// </summary>
        [JsonProperty("AccountIdentify")]
        public long? AccountIdentify{ get; set; }

        /// <summary>
        /// 子账号所属主账号昵称
        /// </summary>
        [JsonProperty("AccountMainNickName")]
        public string AccountMainNickName{ get; set; }

        /// <summary>
        /// 告警时间戳Unix时间单位毫秒
        /// </summary>
        [JsonProperty("AlarmTimestamp")]
        public long? AlarmTimestamp{ get; set; }

        /// <summary>
        /// 处置状态 0 未处理 1 标记处置 2标记忽略
        /// </summary>
        [JsonProperty("HandleStatus")]
        public long? HandleStatus{ get; set; }

        /// <summary>
        /// 告警对象id
        /// </summary>
        [JsonProperty("AlarmId")]
        public long? AlarmId{ get; set; }

        /// <summary>
        /// 桶地域码值
        /// </summary>
        [JsonProperty("BucketRegionCode")]
        public string BucketRegionCode{ get; set; }

        /// <summary>
        /// 数据识别分类详情
        /// </summary>
        [JsonProperty("CategoryDetails")]
        public CosIdentifyCategoryDetail[] CategoryDetails{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "PolicyAbnormalType", this.PolicyAbnormalType);
            this.SetParamSimple(map, prefix + "PolicyRiskLevel", this.PolicyRiskLevel);
            this.SetParamSimple(map, prefix + "PolicyDescription", this.PolicyDescription);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "BucketRegion", this.BucketRegion);
            this.SetParamSimple(map, prefix + "BucketMarker", this.BucketMarker);
            this.SetParamSimple(map, prefix + "BucketTagInfo", this.BucketTagInfo);
            this.SetParamSimple(map, prefix + "BucketAccessWay", this.BucketAccessWay);
            this.SetParamSimple(map, prefix + "AccountUin", this.AccountUin);
            this.SetParamSimple(map, prefix + "AccountNickName", this.AccountNickName);
            this.SetParamSimple(map, prefix + "AccountIdentify", this.AccountIdentify);
            this.SetParamSimple(map, prefix + "AccountMainNickName", this.AccountMainNickName);
            this.SetParamSimple(map, prefix + "AlarmTimestamp", this.AlarmTimestamp);
            this.SetParamSimple(map, prefix + "HandleStatus", this.HandleStatus);
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "BucketRegionCode", this.BucketRegionCode);
            this.SetParamArrayObj(map, prefix + "CategoryDetails.", this.CategoryDetails);
        }
    }
}

