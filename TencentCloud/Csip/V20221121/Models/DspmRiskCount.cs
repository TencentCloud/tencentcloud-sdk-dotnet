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

    public class DspmRiskCount : AbstractModel
    {
        
        /// <summary>
        /// 待处理风险个数
        /// </summary>
        [JsonProperty("UnprocessedRisk")]
        public long? UnprocessedRisk{ get; set; }

        /// <summary>
        /// 配置风险个数
        /// </summary>
        [JsonProperty("ConfigurationRisk")]
        [System.Obsolete]
        public long? ConfigurationRisk{ get; set; }

        /// <summary>
        /// 基线风险个数
        /// </summary>
        [JsonProperty("BaselineDeviation")]
        [System.Obsolete]
        public long? BaselineDeviation{ get; set; }

        /// <summary>
        /// 泄露风险个数
        /// </summary>
        [JsonProperty("LeakDetection")]
        [System.Obsolete]
        public long? LeakDetection{ get; set; }

        /// <summary>
        /// SQL行为异常风险个数
        /// </summary>
        [JsonProperty("SQLBehaviorAnomaly")]
        public long? SQLBehaviorAnomaly{ get; set; }

        /// <summary>
        /// 权限异常风险个数
        /// </summary>
        [JsonProperty("PermissionAnomaly")]
        public long? PermissionAnomaly{ get; set; }

        /// <summary>
        /// 登录行为异常风险个数
        /// </summary>
        [JsonProperty("LoginBehaviorAnomaly")]
        public long? LoginBehaviorAnomaly{ get; set; }

        /// <summary>
        /// 攻击面风险个数
        /// </summary>
        [JsonProperty("AttackSurfaceRisk")]
        public long? AttackSurfaceRisk{ get; set; }

        /// <summary>
        /// 账号敏感操作个数
        /// </summary>
        [JsonProperty("AccountSensitiveOperation")]
        public long? AccountSensitiveOperation{ get; set; }

        /// <summary>
        /// 待处理告警个数
        /// </summary>
        [JsonProperty("UnprocessedAlarm")]
        public long? UnprocessedAlarm{ get; set; }

        /// <summary>
        /// 新增事件告警
        /// </summary>
        [JsonProperty("NumOfNewAlarmEvent")]
        public long? NumOfNewAlarmEvent{ get; set; }

        /// <summary>
        /// 新增配置风险
        /// </summary>
        [JsonProperty("NumOfNewConfigRisk")]
        public long? NumOfNewConfigRisk{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UnprocessedRisk", this.UnprocessedRisk);
            this.SetParamSimple(map, prefix + "ConfigurationRisk", this.ConfigurationRisk);
            this.SetParamSimple(map, prefix + "BaselineDeviation", this.BaselineDeviation);
            this.SetParamSimple(map, prefix + "LeakDetection", this.LeakDetection);
            this.SetParamSimple(map, prefix + "SQLBehaviorAnomaly", this.SQLBehaviorAnomaly);
            this.SetParamSimple(map, prefix + "PermissionAnomaly", this.PermissionAnomaly);
            this.SetParamSimple(map, prefix + "LoginBehaviorAnomaly", this.LoginBehaviorAnomaly);
            this.SetParamSimple(map, prefix + "AttackSurfaceRisk", this.AttackSurfaceRisk);
            this.SetParamSimple(map, prefix + "AccountSensitiveOperation", this.AccountSensitiveOperation);
            this.SetParamSimple(map, prefix + "UnprocessedAlarm", this.UnprocessedAlarm);
            this.SetParamSimple(map, prefix + "NumOfNewAlarmEvent", this.NumOfNewAlarmEvent);
            this.SetParamSimple(map, prefix + "NumOfNewConfigRisk", this.NumOfNewConfigRisk);
        }
    }
}

