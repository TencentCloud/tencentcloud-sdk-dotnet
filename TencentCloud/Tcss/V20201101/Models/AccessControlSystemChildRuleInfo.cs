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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessControlSystemChildRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 子策略Id
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 策略模式,  RULE_MODE_RELEASE: 放行
        ///    RULE_MODE_ALERT: 告警
        ///    RULE_MODE_HOLDUP:拦截
        /// </summary>
        [JsonProperty("RuleMode")]
        public string RuleMode{ get; set; }

        /// <summary>
        /// 子策略状态，true为开启，false为关闭
        /// </summary>
        [JsonProperty("IsEnable")]
        public bool? IsEnable{ get; set; }

        /// <summary>
        /// 子策略检测的入侵行为类型
        /// CHANGE_CRONTAB：篡改计划任务
        /// CHANGE_SYS_BIN：篡改系统程序
        /// CHANGE_USRCFG：篡改用户配置
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleMode", this.RuleMode);
            this.SetParamSimple(map, prefix + "IsEnable", this.IsEnable);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
        }
    }
}

