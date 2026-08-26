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
        /// 入参限制：1-128个字符，不允许特殊字符
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 动作类型
        /// 取值说明：1-阻断，2-人机识别（滑块），3-观察，4-重定向，5-JS校验，6-人机识别（无感验证-拦截），7-人机识别（无感验证-观察），8-语音验证码
        /// 入参限制：必填，取值范围为1-8
        /// 约束条件：当RuleAction为4（重定向）时，Redirect参数不能为空
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
        [System.Obsolete]
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
        /// 匹配条件的逻辑关系，支持and、or，分别表示多个逻辑匹配条件是与、或的关系
        /// 默认值：and
        /// 入参限制：不区分大小写，仅支持and或or
        /// </summary>
        [JsonProperty("LogicalOp")]
        public string LogicalOp{ get; set; }

        /// <summary>
        /// 动作灰度比例，即规则命中后执行动作的流量百分比
        /// 取值范围：1-100
        /// 默认值：100（全量生效）
        /// </summary>
        [JsonProperty("ActionRatio")]
        public ulong? ActionRatio{ get; set; }


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
            this.SetParamSimple(map, prefix + "LogicalOp", this.LogicalOp);
            this.SetParamSimple(map, prefix + "ActionRatio", this.ActionRatio);
        }
    }
}

