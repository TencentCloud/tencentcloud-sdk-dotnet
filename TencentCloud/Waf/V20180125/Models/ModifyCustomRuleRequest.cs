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

    public class ModifyCustomRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 编辑的域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 编辑的规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// 编辑的规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 执行动作，0：放行、1：阻断、2：人机识别、3：观察、4：重定向
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// 匹配条件数组
        /// </summary>
        [JsonProperty("Strategies")]
        public Strategy[] Strategies{ get; set; }

        /// <summary>
        /// WAF的版本，clb-waf代表负载均衡WAF、sparta-waf代表SaaS WAF，默认是sparta-waf。
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// 动作为重定向的时候重定向URL，默认为"/"
        /// </summary>
        [JsonProperty("Redirect")]
        public string Redirect{ get; set; }

        /// <summary>
        /// 放行时是否继续执行其它检查逻辑，继续执行地域封禁防护：geoip、继续执行CC策略防护：cc、继续执行WEB应用防护：owasp、继续执行AI引擎防护：ai、继续执行信息防泄漏防护：antileakage。如果多个勾选那么以,串接。
        /// 默认是"geoip,cc,owasp,ai,antileakage"
        /// </summary>
        [JsonProperty("Bypass")]
        public string Bypass{ get; set; }

        /// <summary>
        /// 优先级，1~100的整数，数字越小，代表这条规则的执行优先级越高。
        /// 默认是100
        /// </summary>
        [JsonProperty("SortId")]
        public ulong? SortId{ get; set; }

        /// <summary>
        /// 规则生效截止时间，0：永久生效，其它值为对应时间的时间戳。
        /// 默认是0
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// 定时任务类型
        /// </summary>
        [JsonProperty("JobType")]
        public string JobType{ get; set; }

        /// <summary>
        /// 定时任务配置
        /// </summary>
        [JsonProperty("JobDateTime")]
        public JobDateTime JobDateTime{ get; set; }

        /// <summary>
        /// 规则来源，判断是不是小程序的
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 开关状态，小程序风控规则的时候传该值
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 拦截页面id
        /// </summary>
        [JsonProperty("PageId")]
        public string PageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamArrayObj(map, prefix + "Strategies.", this.Strategies);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "Redirect", this.Redirect);
            this.SetParamSimple(map, prefix + "Bypass", this.Bypass);
            this.SetParamSimple(map, prefix + "SortId", this.SortId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamObj(map, prefix + "JobDateTime.", this.JobDateTime);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PageId", this.PageId);
        }
    }
}

