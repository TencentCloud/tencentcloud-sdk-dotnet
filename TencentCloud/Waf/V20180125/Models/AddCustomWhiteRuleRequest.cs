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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddCustomWhiteRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [JsonProperty("SortId")]
        public string SortId{ get; set; }

        /// <summary>
        /// 策略详情
        /// </summary>
        [JsonProperty("Strategies")]
        public Strategy[] Strategies{ get; set; }

        /// <summary>
        /// 需要添加策略的域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 放行的模块，多个模块之间用逗号连接。支持的模块：acl（自定义规则）、owasp（规则引擎）、webshell（恶意文件检测）、geoip（地域封禁）、bwip（IP黑白名单）、cc、botrpc（BOT防护）、antileakage（信息防泄露）、api（API安全）、ai（AI引擎）、ip_auto_deny（IP封禁）、applet（小程序流量风控）
        /// </summary>
        [JsonProperty("Bypass")]
        public string Bypass{ get; set; }

        /// <summary>
        /// 如果没有设置JobDateTime字段则用此字段，0表示永久生效，其它表示定时生效的截止时间（单位为秒）
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 规则执行的方式，TimedJob为定时执行，CronJob为周期执行
        /// </summary>
        [JsonProperty("JobType")]
        public string JobType{ get; set; }

        /// <summary>
        /// 定时任务配置
        /// </summary>
        [JsonProperty("JobDateTime")]
        public JobDateTime JobDateTime{ get; set; }

        /// <summary>
        /// 匹配条件的逻辑关系，支持and、or，分别表示多个逻辑匹配条件是与、或的关系
        /// </summary>
        [JsonProperty("LogicalOp")]
        public string LogicalOp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SortId", this.SortId);
            this.SetParamArrayObj(map, prefix + "Strategies.", this.Strategies);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Bypass", this.Bypass);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamObj(map, prefix + "JobDateTime.", this.JobDateTime);
            this.SetParamSimple(map, prefix + "LogicalOp", this.LogicalOp);
        }
    }
}

